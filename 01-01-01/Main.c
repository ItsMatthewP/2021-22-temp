#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

//The main function or entry point of the program
int main() {
	int i;
	printf("Number: ");
	scanf("%d", &i);
	if (i % 2 == 0 && i != 0) {
		printf("Your number is even");
		return 0;
	}
	else if (i <= 0) {
		printf("Your number is less than or equal to 0");
		return 0;
	}
	else {
		printf("Your number is odd");
	}
	return 0;
}
