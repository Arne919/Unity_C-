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


	//p1 p2�� ���� x y �� �Է� �ޱ�
	scanf_s("%f", &p1.x);
	scanf_s("%f", &p2.x);
	scanf_s("%f", &p1.y);
	scanf_s("%f", &p2.y);

	printf("%f", Distance(p1,p2));




	//Point p1, p2;


	////p1 x y �Է¹ޱ� scanf
	//scanf_s("%f", &p1.x);
	//scanf_s("%f", &p2.x);
	//scanf_s("%f", &p1.y);
	//scanf_s("%f", &p2.y);

	////p1�� x���� y�� ����ϱ�
	////printf("%.1f, %.1f", p1.x, p1.y);

	////p1 p2�� ���� x y �� �Է� �ޱ�
	////p1 p2�� x�Ÿ� ����ϱ�
	////p1 p2�� y�Ÿ� ����ϱ�

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

	//printf("x�Ÿ� %.1f, y�Ÿ� %.1f", xdis, ydis);

}