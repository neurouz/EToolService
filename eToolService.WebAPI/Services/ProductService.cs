using AutoMapper;
using EToolService.Model.Requests;
using EToolService.WebAPI.Database;
using EToolService.WebAPI.Exceptions;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Services
{
    public class ProductService : IProductService
    {
        private RecommenderService _recommenderService;
        private readonly Context _context;
        private readonly IMapper _mapper;
        public ProductService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _recommenderService = new RecommenderService(mapper, context);
        }

        public async Task<List<Model.Models.Product>> Get(ProductSearchRequest request)
        {
            var products = _context.Product.AsQueryable().Where(x => x.Active == true);

            if(request.Page != -1)
            {
                products = products
                    .Skip((request.Page - 1) * request.ItemsPerPage)
                    .Take(request.ItemsPerPage);
            }

            var result = _mapper.Map<List<Model.Models.Product>>(products);

            foreach(var product in result)
            {
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Products", $"{product.ImageLocation}");

                product.Image = await FindImage(directory);
                product.Price = Math.Round(product.Price, 2);
            }
            return result;
        }
        public async Task<Model.Models.Product> Get(int id)
        {
            var entity = _context.Product.Find(id);
            if (entity == null)
                throw new UserException("Proizvod ne postoji u bazi");

            var result = _mapper.Map<Model.Models.Product>(entity);
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Products", $"{result.ImageLocation}");

            result.Image = await FindImage(directory);
            return result;
        }

        public async Task<List<Model.Models.Product>> Recommend([FromQuery] int clientId)
        {
            var products = await _recommenderService.Recommend(clientId);
            foreach(var product in products)
            {
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Products", $"{product.ImageLocation}");

                product.Image = await FindImage(directory);
            }
            return products;
        }

        public async Task<Model.Models.Product> Update(int id, ProductUpdateRequest request)
        {

            var entity = _context.Product.Find(id);
            if (entity == null)
                throw new UserException("Proizvod ID nije validan");

            await Map(entity, request);
            await _context.SaveChangesAsync();
            var result = _mapper.Map<Model.Models.Product>(entity);
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Products", $"{result.ImageLocation}");

            result.Image = await FindImage(directory);
            return result;
        }

        private async Task<byte[]> FindImage(string path)
        {
            try
            {
                 return await System.IO.File.ReadAllBytesAsync(path);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task ReplaceImage(Database.Product product, string imageName, byte[] byteArray)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Products", $"{product.ImageLocation}");

            try
            {
                File.Delete(path);
            }
            catch (Exception) { }
            
            try
            {
                var filename = $"product_{product.Id.ToString()}";
                var extension = Path.GetExtension(imageName);
                var newPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", 
                    "Products", $"{filename}{extension}");

                await File.WriteAllBytesAsync(newPath, byteArray);
                product.ImageLocation = $"{filename}{extension}";

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new UserException("Dogodila se greska prilikom izmjene proizvoda. Provjerite podatke");
            }
        }

        private async Task<Database.Product> Map(Database.Product product, ProductUpdateRequest request)
        {
            product.Condition = request.Condition != null ? request.Condition : product.Condition;
            product.Discount = request.Discount != product.Discount ? request.Discount : product.Discount;
            product.Description = request.Description != null ? request.Description : product.Description;
            if(request.Image != null)
            {
                if(request.Image.Length != 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Images", "Products", $"{product.ImageLocation}");
                    var image = FindImage(path);
                    if (image != null)
                    {
                        await ReplaceImage(product, request.ImageFileName, request.Image);
                    }
                }
            }
            product.Price = (decimal)request.Price;
            product.ProductName = request.ProductName != null ? request.ProductName : product.ProductName;

            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Model.Models.Product> SetInactive(int id)
        {
            var product = _context.Product.Find(id);
            if(product == null)
                throw new UserException("Proizvod ne postoji u bazi");

            product.Active = false;

            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Models.Product>(product);
        }
    }
}
