#include<stdio.h>
/// <summary>
/// ��ü�ϴ� �Լ�
/// </summary>
/// <param name="send">�� ������ ���</param>
/// <param name="receive">�� �޴� ���</param>
/// <param name="money">�ݾ�</param>
void Transfer(int* send, int* receive,int money)
{
	//������ ����� �ݾ׿��� �Ӵϸ�ŭ�� ����.
	//������ ����� �ݾ� -> �Ӵϸ�ŭ �����Ѵ�.
	*send -= money;
	//�޴� ����� �ݾ׿��� �Ӵϸ�ŭ ���Ѵ�
	*receive += money;
}

int main(void)
{
	//�μ��� ����
	int minsu = 10000;
	//ö���� ����
	int chulsu = 30000;

	Transfer(&minsu, &chulsu, 5000);

	printf("%d\n", minsu);
	printf("%d\n", chulsu);

}    


//void test(int* num)
//{
//	*num += 10;
//}
//
//
//int main(void)
//{
//	int num = 30;
//	test(&num);
//	printf("%d", num);



	//int minsu = 10000;
	//int chulsu = 30000;

	//int* atm;

	////atm ��⿡ �μ� ���� ����
	//atm = &minsu;
	//
	//*atm -= 1000;
	//printf("%d", minsu);



	//int num = 3;
	//int* ptr;
	////ptr�� ���� num�� �ּҴ�.
	//ptr = &num;

	//printf("%d\n", num); // 3


	////num�� �ּҿ� �ִ� ���� 5�� �ʱ�ȭ
	//*ptr = 5;


	//printf("%d\n", num); // 5
//}