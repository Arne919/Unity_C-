#include<stdio.h>
#include<math.h>

struct Point
{
	float x;
	float y;
};
float Distance(Point p1, Point p2)
{
	return sqrt((p1.x - p2.x)* (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
}
int main(void)
{
	Point p1, p2;


	//p1 p2에 대해 x y 값 입력 받기
	scanf_s("%f", &p1.x);
	scanf_s("%f", &p2.x);
	scanf_s("%f", &p1.y);
	scanf_s("%f", &p2.y);

	printf("%f", Distance(p1,p2));




	//Point p1, p2;


	////p1 x y 입력받기 scanf
	//scanf_s("%f", &p1.x);
	//scanf_s("%f", &p2.x);
	//scanf_s("%f", &p1.y);
	//scanf_s("%f", &p2.y);

	////p1의 x값과 y값 출력하기
	////printf("%.1f, %.1f", p1.x, p1.y);

	////p1 p2에 대해 x y 값 입력 받기
	////p1 p2의 x거리 출력하기
	////p1 p2의 y거리 출력하기

	//float xdis = p1.x - p2.x;
	//if (xdis < 0)
	//{
	//	xdis *= -1;
	//}
	//float ydis = p1.y - p2.y;
	//if (ydis < 0)
	//{
	//	ydis *= -1;
	//}

	//printf("x거리 %.1f, y거리 %.1f", xdis, ydis);

}