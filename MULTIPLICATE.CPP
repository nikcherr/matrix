#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#define MAXSIZE 10

void display(int n, int x[MAXSIZE*2])
{ 
	for (int i = 0; i <= n; i++ )
		{
			printf("%d\t", x[i]);
		}
	printf("\n");
}


void main()
{
	int i, j, f, s, first[MAXSIZE], second[MAXSIZE], result[MAXSIZE*2];
	printf("\n First polinom degree:\n");
	scanf("%d", &f);
	printf("\n First polinom koeff:\n");
	for (i = 0; i <= f; i++)
	{
		scanf("%d", &first[i]);
	}
	printf("\n Second polinom degree:\n");
	scanf("%d", &s);
	printf("\n Second polinom koeff:\n");
	for (i = 0; i <= s; i++)
	{
		scanf("%d", &second[i]);
	}
	printf("\n First polinom:\n");
	display(f, first);
	printf("\n Second polinom:\n");
	display(s, second);
	for (i = 0; i <= f; i++)
    {
        for (j = 0; j <= s; j++)
        {
            result[i + j] += first[i] * second[j];
        }
    }
	printf("\n Result polinom:\n");
	display(f + s, result);
	getch();
}