#include<stdio.h>


struct Node
{
	int data; //들어있는 값
	Node* next;//다음 노드의 주소
};

Node* head = NULL;//시작 노드

/// <summary>
/// 마지막에 노드를 추가하는 함수
/// </summary>
/// <param name="data">마지막 노드의 데이터</param>
void AddNode(int data)
{
	//새노드
	Node* newNode = new Node; //노드에 새 노드를 추가하기
	newNode->data = data; //새노드의 data는 data로 초기화
	newNode->next = NULL;//새노드의 next는 NULL로 초기화

	//데이터가 없을때
	//맨 처음 데이터 추가할때
	if (head == NULL)
	{
		head = newNode;
	}
	//맨 처음 데이터가 있을때
	//하나이상의 데이터가 있을때
	else
	{
		Node* me = head;//시작지점

		//다음 노드가 존재한다면
		while (me->next != NULL)
		{
			//나는 다음사람을 가리킨다.
			me = me->next;
		}
		//빠져나오면 나의 다음 노드가 없을때
		//내가 마지막
		me->next = newNode;//내 다음노드는 NULL
	}
}

/// <summary>
/// 마지막 노드를 제거하는 함수
/// </summary>
void RemoveNode()
{
	//데이터가 없을때
	if (head == NULL)
	{
		printf("제거할 노드가 존재하지 않습니다.\n");
		return;
	}
	//데이터가 하나마나 있을때 head != null
	if (head->next == NULL)
	{
		delete(head);
		head = NULL;
	}
	//여러개 있을때
	else
	{
		Node* me = head;
		while (me->next != NULL)
		{
			me = me->next;
		}
		delete(me->next);
		me->next = NULL;
	}
}
/// <summary>
/// 전체 출력하는 함수
/// </summary>
void PrintAll()
{

	//데이터가 없을때
	if (head == NULL)
	{
		printf("출력할 데이터가 없습니다.\n");
		return;
	}
	printf("-----------출력결과-----------\n");

	Node* me = head;

	while (me->next != NULL)
	{
		printf("%d\n", me->data);
		me = me->next;
	}
	printf("%d\n", me->data);

	printf("------------------------------\n");
}
/// <summary>
/// 삽입하는 함수
/// </summary>
/// <param name="data"></param>
/// <param name="index"></param>
void Insert(int data, int index)
{
	//2. 마이너스 입력
	if(index < 0)
	{
		printf("인덱스 오류\n");
		return;
	}

	Node* newNode = new Node;
	newNode->data = data;
	newNode->next = NULL;
	//맨처음 추가할때
	if (index == 0)
	{
		newNode->next = head;
		head = newNode;
	}
	else
	{
		Node* me = head;
		for (int i = 0; i < index - 1; i++)
		{
			me = me->next;
		}
		newNode->next = me->next;
		me->next = newNode;

		//C다음 B
		//A다음 ->C

		//A의미 추가할 인덱스 이전
		//B의미 추가할 인덱스 다음
		//C의미 추가할 인덱스 이전

	}

	//벗어났을때
	//1.길이보다 큰 값을 입력할 경우

}
/// <summary>
/// 지정 삭제하는 함수
/// </summary>
/// <param name="index"></param>
void RemoveAt(int index)
{
	//2. 마이너스 입력
	if (index < 0)
	{
		printf("인덱스 오류\n");
		return;
	}
	if (index == 0)
	{
		Node* temp = head->next;
		delete(head);
		head = temp;
		return;
	}
	Node* me = head;
	for (int i = 0; i < index - 1; i++)
	{
		me = me ->next;
	}
	Node* temp = me ->next;
	delete(me->next);
	me->next = temp;



}

int main(void)
{
	AddNode(1);
	AddNode(2);
	AddNode(3);
	AddNode(4);
	PrintAll();

	Insert(99, 2);
	PrintAll();

	//AddNode(50);
	//RemoveNode();
	//AddNode(20);
	//printf("%d\n", head->next->data);


}