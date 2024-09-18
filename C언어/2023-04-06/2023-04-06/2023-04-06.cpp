#include<stdio.h>
/// <summary>
/// 이체하는 함수
/// </summary>
/// <param name="send">돈 보내는 사람</param>
/// <param name="receive">돈 받는 사람</param>
/// <param name="money">금액</param>
void Transfer(int* send, int* receive,int money)
{
	//보내는 사람의 금액에서 머니만큼을 뺀다.
	//보내는 사람의 금액 -> 머니만큼 감소한다.
	*send -= money;
	//받는 사람의 금액에서 머니만큼 더한다
	*receive += money;
}

int main(void)
{
	//민수의 통장
	int minsu = 10000;
	//철수의 통장
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

	////atm 기기에 민수 통장 넣음
	//atm = &minsu;
	//
	//*atm -= 1000;
	//printf("%d", minsu);



	//int num = 3;
	//int* ptr;
	////ptr의 값은 num의 주소다.
	//ptr = &num;

	//printf("%d\n", num); // 3


	////num의 주소에 있는 값을 5로 초기화
	//*ptr = 5;


	//printf("%d\n", num); // 5
//}