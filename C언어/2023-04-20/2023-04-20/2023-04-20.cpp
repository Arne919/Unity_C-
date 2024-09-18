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
	Node* last = NULL;//마지막을 찾기
	last = new Node;//마지막 노드에 새 노드를 추가하기
	last->data = data;//새노드의 data는 data로 초기화
	last->next = NULL;//새노드의 next는 NULL로 초기화



	if (head == NULL)//헤드 노드가 없으면
	{
		head = last;//헤드는 마지막 노드다.
		printf("%d\n", last->data);
	}
	else
	{
		Node* temp=head;//시작지점
		temp->next = NULL; //NULL 전 노드 찾기
		temp->data = data;//NULL전 노드 data로 초기화

		while (temp->next != NULL) //마지막노드 찾는 반복문
		{
			temp = temp->next;
		}
		temp->next = new Node; //마지막 노드일경우 새노드에 초기화
		printf("%d\n", last->data);
	}
}


int main(void)
{
	AddNode(10);
	AddNode(20);
	AddNode(30);
	AddNode(40);
}