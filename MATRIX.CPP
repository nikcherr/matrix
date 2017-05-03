#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#define MAXSIZE 10
void display(int n,int x[MAXSIZE][MAXSIZE])
{ 
	for (int i = 0; i < n; i++ )
		{
			for (int j = 0; j < n; j++ )
				printf("%d\t", x[i][j]);
	    printf("\n");
		}
}

void getResult(int n, int x[MAXSIZE][MAXSIZE])
{
	int temp = 0;
	int result[MAXSIZE][MAXSIZE];
	for (int i = 0; i < n; i++)
	{
		for(int j = 0; j < n; j++)
		{
			if(i > 0 && j < i)
			{
				result[i][j] = result[j][i];
				continue;
			}
			for(int k = 0; k + i < n && k + j < n; k++)
			{
				temp += x[k + i][k + j];
			}
			result[i][j] = temp;
			temp = 0;
		}
	}
	printf("Result matrix: %d*%d \n", n, n);
	display(n, result);
}

void main()
{
	int i, j, matrix[MAXSIZE][MAXSIZE], n;
	printf("\n Matrix size:\n");
	scanf("%d", &n);
	for (i = 0; i < n; i++)
	{
		for(j = 0; j < n; j++)
		{
			if(i > 0 && j < i)
			{
				matrix[i][j] = matrix[j][i];
			}
			else 
				matrix[i][j] = rand()%10;
		}
	}
	printf("Matrix: %d*%d \n", n, n);
	display(n, matrix);
	getResult(n, matrix);
	getch();
}