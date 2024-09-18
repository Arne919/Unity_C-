#include<stdio.h>

//int main(void)
//{

	//int arr[] = {1,3,4,5,2,6,9,8,7};  // 추가로 만들어 보기 (배열중 큰 수 찾기?)
	//int big = arr[0];	 
	//for (int i = 0; i < 10; i++)
	//{
	//	if (big < arr[i])
	//	{
	//		 big = arr[i];
	//	}
	//}
	// printf("%d", big);



	//2. 역삼각형 피라미드
	//	층 입력 받아서 층만큼 출력하기

	//int floor;
	//printf("층수? ");
	//scanf_s("%d", &floor);

	//for (int i = 0; i <= floor; i++)
	//{
	//	for (int j = 0; j < i; j++)
	//	{
	//		printf(" ");
	//	}
	//	for (int k = 0; k < (floor-i)*2-1; k++)
	//	{
	//		printf("*"); // *하나로 만들기
	//	}
	//	printf("\n");
	//}



	//15. 길이가 13인 배열 선언
	//	n번 인덱스의 값은 n으로 초기화
	//	오른쪽으로 밀기

	//int arr[13];
	//int num = 0;

	//for (int i = 0; i < 13; i++) //배열 초기화
	//{
	//	arr[i] = num++;
	//}

	//int temp = arr[12]; //마지막 배열 저장

	//for (int i = 12; i > 0; i--) //한칸씩 밀기
	//{
	//	arr[i] = arr[i - 1];
	//}
	//arr[0] = temp; //맨 앞 배열 저장한 값 넣기

	//for (int i = 0; i < 13; i++) //출력
	//{
	//	printf("%d ", arr[i]);
	//}




	//16. 15번에 대해 어느 방향으로 밀건지 입력받기
	//	얼마만큼 밀건지 입력받기
	//	입력받은 값에 대해 바뀐 배열 출력하기

	//int arr[13];
	//int num = 0;
	//int choice; //왼?오?
	//int count; //얼마만큼?

	//for (int i = 0; i < 13; i++) //배열 초기화
	//{
	//	arr[i] = num++;
	//}
	//for (int i = 0; i < 13; i++) //출력
	//{
	//	printf("%d ", arr[i]);
	//}

	//printf("\n 위 배열을 어느 방향으로 밀건가요? (오른쪽:1, 왼쪽:2) ");
	//scanf_s("%d", &choice);

	//printf("얼마만큼 밀겁니까? ");
	//scanf_s("%d", &count);
	// 
	//if (choice == 1) //오른쪽
	//{
	//	for (int i = 0; i < count; i++) //입력받은 만큼 저장
	//	{
	//		int temp = arr[12]; //배열 저장
	// 
	//		for (int j = 12; j > 0; j--) //오른쪽으로 밀기
	//		{
	//			arr[j] = arr[j - 1];
	//		}
	//	arr[0] = temp; //저장한 값 넣기
	//}
	//}
	//else if (choice == 2) //왼쪽
	//{
		//for (int i = 0; i < count; i++)
		//{
		//	int temp = arr[0]; //배열 저장

		//	for (int j = 0; j < 12; j++) //왼쪽으로 밀기
		//	{
		//		arr[j] = arr[j + 1];
		//	}
		//	arr[12] = temp;//저장한 값 넣기
	//	}


	//}
	//for (int i = 0; i < 13; i++) //출력
	//{
	//	printf("%d ", arr[i]);
	//}



	//17. 2차원 배열 만들기
	//	가로가 3 세로가 4인 배열 기준
	//	1 5 9
	//	2 6 10
	//	3 7 11
	//	4 8 12
	//	이 배열을 16번처럼 방향과 얼마나 밀건지 입력받아서
	//	밀어주기 이후 출력하기

	//const int x = 3;
	//const int y = 4;
	//int arr[y][x];
	//int num = 1;
	//int choice;//왼?오?
	//int count;//얼마만큼?

	//for (int i = 0; i < y; i++)//세로로 배열
	//{
	//	int temp = num;

	//	for (int j = 0; j < x; j++)
	//	{
	//		arr[i][j] = temp;
	//		temp += y;
	//	}
	//	num++;
	//}
	//for (int i = 0; i < y; i++)//변경전 배열
	//{
	//	for (int j = 0; j < x; j++)
	//	{
	//		printf("%d ", arr[i][j]);
	//	}
	//	printf("\n");
	//}

	//printf("위 배열을 어느 방향으로 밀건가요? (오른쪽:1, 왼쪽:2) ");
	//scanf_s("%d", &choice);

	//printf("얼마만큼 밀겁니까? ");
	//scanf_s("%d", &count);

	//if (choice == 1) //오른쪽
	//{
	//	for (int i = 0; count > 0; count--) //입력받은 만큼 저장
	//	{
	//		int temp = arr[y - 1][x - 1]; //마지막 배열 저장

	//		for (int i = y - 1; i >= 0; i--)
	//		{
	//			for (int j = x - 1; j > 0; j--)
	//			{
	//				arr[i][j] = arr[i][j - 1];
	//			}
	//			if (i > 0) //행 변경하여 밀기
	//			{
	//				arr[i][0] = arr[i - 1][x - 1];
	//			}
	//		}
	//		arr[0][0] = temp; //첫 배열에 값 넣기
	//	}
	//}

	//else if (choice == 2) //왼쪽
	//{
	//	for (int i = 0; count > 0; count--)//입력받은 만큼 저장
	//	{
	//		int temp = arr[0][0]; // 첫 배열 저장

	//		for (int i = 0; i <= y - 1; i++)
	//		{
	//			for (int j = 0; j < x - 1; j++)
	//			{
	//				arr[i][j] = arr[i][j + 1];
	//			}
	//			if (i <= y) //행 변경하여 밀기
	//			{
	//				arr[i][x - 1] = arr[i + 1][0];
	//			}
	//		}
	//		arr[y - 1][x - 1] = temp; //마지막 배열에 값 넣기
	//	}
	//}

	//for (int i = 0; i < y; i++) //출력
	//{
	//	for (int j = 0; j < x; j++)
	//	{
	//		printf("%d ", arr[i][j]);
	//	}
	//	printf("\n");
	//}
//}



	//18. ADD 함수 만들기
	//	매개변수 2개
	//	두 매개변수를 더한 값을 반환 하기
	//	int형 float형 2개 만들기
//int Add_int(int a, int b)
//{
//	return  a + b;
//}
//float Add_float(float a, float b)
//{
//	return a + b;
//}
//int main(void)
//{
//	printf("%d\n", Add_int(1, 2));
//	printf("%.2f\n", Add_float(1.111, 2.222));
//}



//19. 매개변수로 배열을 받아 왼쪽으로 돌린 배열을 반환하는 함수와
//	오른쪽으로 돌린 배열을 반환하는 함수 2개 만들기

const int length = 10;

int Arr_right(int arr[length])
{

		int temp = arr[length-1]; //배열 저장

		for (int j = length-1; j > 0; j--) //오른쪽으로 밀기
		{
			arr[j] = arr[j - 1];
		}
		arr[0] = temp; //저장한 값 넣기
		return arr[length];

}

int Arr_left(int arr[length])
{

	int temp = arr[0]; //배열 저장

	for (int j = 0; j < length; j++) //왼쪽으로 밀기
	{
		arr[j] = arr[j + 1];
	}
	arr[length - 1] = temp;//저장한 값 넣기
	return arr[length];

}

int main(void)
{
	int arr[length];
	for (int i = 0; i < length; i++) //초기화
	{
		arr[i] = i;
	}


	Arr_right(arr);//오른쪽
	for (int i = 0; i < length; i++)
	{
		printf("%2d", arr[i]);
	}
	printf("\n");


	for (int i = 0; i < length; i++)//초기화
	{
		arr[i] = i;
	}

	Arr_left(arr);//왼쪽
	for (int i = 0; i < length; i++)
	{
		printf("%2d", arr[i]);
	}

}