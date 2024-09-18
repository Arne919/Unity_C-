#include<stdio.h>


struct Node
{
	int data; //����ִ� ��
	Node* next;//���� ����� �ּ�
};

Node* head = NULL;//���� ���

/// <summary>
/// �������� ��带 �߰��ϴ� �Լ�
/// </summary>
/// <param name="data">������ ����� ������</param>
void AddNode(int data)
{
	Node* last = NULL;//�������� ã��
	last = new Node;//������ ��忡 �� ��带 �߰��ϱ�
	last->data = data;//������� data�� data�� �ʱ�ȭ
	last->next = NULL;//������� next�� NULL�� �ʱ�ȭ



	if (head == NULL)//��� ��尡 ������
	{
		head = last;//���� ������ ����.
		printf("%d\n", last->data);
	}
	else
	{
		Node* temp=head;//��������
		temp->next = NULL; //NULL �� ��� ã��
		temp->data = data;//NULL�� ��� data�� �ʱ�ȭ

		while (temp->next != NULL) //��������� ã�� �ݺ���
		{
			temp = temp->next;
		}
		temp->next = new Node; //������ ����ϰ�� ����忡 �ʱ�ȭ
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