using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EToolService.WebAPI.Helpers
{
    public class SmithWaterman
    {
        const int M = 100;
        const int N = 100;
        const int NALIGN = 200;

        const int STOP = 0;
        const int UP = 1;
        const int LEFT = 2;
        const int DIAG = 3;

        const int MATCHSCORE = 1;
        const int MISMATCHSCORE = -1;
        const int GAPSCORE = -1;

        public static float GetSimilarity(string firstText, string secondText) {

			int i, j, tmp, length;
			int[,] distance = new int[M,N];  	/* distance label matrix */
			int[,] trace = new int[M,N];     	/* trace matrix */
			char[] alignX = new char[NALIGN]; 	/* aligned X sequence */
			char[] alignY = new char[NALIGN]; 	/* aligned Y sequence */
	
			// initialization
			for (int k = 0; k < firstText.Length; k++) distance[k,0] = 0;
			for (int k = 0; k < secondText.Length; k++) distance[0, k] = 0;
			for (int k = 0; k < firstText.Length; k++)	distance[k, 0] = STOP;
			for (int k = 0; k < secondText.Length; k++) distance[0, k] = STOP;
			int minDist = 0, minI = 0, minJ = 0;

			// labeling of all nodes, this is the main loop of the algorithm
			//    for i:=1; i<=len(firstText); i++ {    /* note: we begin at i=1 ! */
			for(i = 1; i < firstText.Length; i++)
            {
				for(j = 1; j < secondText.Length; j++)
                {
					int dist = 0; /* distance to node (i,j) from virtual start node */
					trace[i,j] = STOP;
					if (firstText[i-1] == secondText[j-1]) {
						tmp = distance[i - 1, j - 1] - MATCHSCORE;
					} else {
						tmp = distance[i - 1, j - 1] - MISMATCHSCORE;
					}
					if (tmp < dist) {
						dist = tmp;
						trace[i, j] = DIAG;
					}

					tmp = distance[i - 1, j] - GAPSCORE;
					if (tmp < dist) {
						dist = tmp;
						trace[i, j] = UP;
					}

					tmp = distance[i, j - 1] - GAPSCORE;
					if (tmp < dist) {
						dist = tmp;
						trace[i, j] = LEFT;
					}

					distance[i, j] = dist;

					if (dist < minDist) { /* keep track of where the minimum score is */
						minDist = dist;
						minI = i;
						minJ = j;
					}
				}
			}

			int iAlign = 0;

			for (i = firstText.Length - 1; i > minI; i--) {
				alignY[iAlign] = '*';
				alignX[iAlign] = firstText[i-1];
				iAlign++;
			}

			for (j = secondText.Length - 1; j > minJ; j--) {
				alignY[iAlign] = secondText[j - 1];
				alignX[iAlign] = '*';
				iAlign++;
			}
			while (trace[i, j] != STOP) {
				switch (trace[i, j]) {
					case DIAG:
						alignY[iAlign] = secondText[j - 1];
						alignX[iAlign] = firstText[i - 1];
						i--;
						j--;
						iAlign++;
						break;
					case LEFT:
						alignY[iAlign] = secondText[j - 1];
						alignX[iAlign] = '-';
						j--;
						iAlign++;
						break;
					case UP:
						alignY[iAlign] = '-';
						alignX[iAlign] = firstText[i - 1];
						i--;
						iAlign++;
						break;
				}
			}

			while (i > 0) {
				alignY[iAlign] = '*';
				alignX[iAlign] = firstText[i - 1];
				i--;
				iAlign++;
			}

			while (j > 0) {
				alignY[iAlign] = secondText[j - 1];
				alignX[iAlign] = '*';
				j--;
				iAlign++;
			}

            // count the length as maximum divider of percentage
            if (firstText.Length < secondText.Length) {
                length = firstText.Length;
            }
            else
            {
                length = secondText.Length;
            }

			// return the percentage of similarity
			return (-1 * (float)minDist / (float)length) * 100;
        }        
    }
}
