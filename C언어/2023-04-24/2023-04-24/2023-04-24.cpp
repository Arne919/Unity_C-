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
	//�����
	Node* newNode = new Node; //��忡 �� ��带 �߰��ϱ�
	newNode->data = data; //������� data�� data�� �ʱ�ȭ
	newNode->next = NULL;//������� next�� NULL�� �ʱ�ȭ

	//�����Ͱ� ������
	//�� ó�� ������ �߰��Ҷ�
	if (head == NULL)
	{
		head = newNode;
	}
	//�� ó�� �����Ͱ� ������
	//�ϳ��̻��� �����Ͱ� ������
	else
	{
		Node* me = head;//��������

		//���� ��尡 �����Ѵٸ�
		while (me->next != NULL)
		{
			//���� ��������� ����Ų��.
			me = me->next;
		}
		//���������� ���� ���� ��尡 ������
		//���� ������
		me->next = newNode;//�� �������� NULL
	}
}

/// <summary>
/// ������ ��带 �����ϴ� �Լ�
/// </summary>
void RemoveNode()
{
	//�����Ͱ� ������
	if (head == NULL)
	{
		printf("������ ��尡 �������� �ʽ��ϴ�.\n");
		return;
	}
	//�����Ͱ� �ϳ����� ������ head != null
	if (head->next == NULL)
	{
		delete(head);
		head = NULL;
	}
	//������ ������
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
/// ��ü ����ϴ� �Լ�
/// </summary>
void PrintAll()
{

	//�����Ͱ� ������
	if (head == NULL)
	{
		printf("����� �����Ͱ� �����ϴ�.\n");
		return;
	}
	printf("-----------��°��-----------\n");

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
/// �����ϴ� �Լ�
/// </summary>
/// <param name="data"></param>
/// <param name="index"></param>
void Insert(int data, int index)
{
	//2. ���̳ʽ� �Է�
	if(index < 0)
	{
		printf("�ε��� ����\n");
		return;
	}

	Node* newNode = new Node;
	newNode->data = data;
	newNode->next = NULL;
	//��ó�� �߰��Ҷ�
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

		//C���� B
		//A���� ->C

		//A�ǹ� �߰��� �ε��� ����
		//B�ǹ� �߰��� �ε��� ����
		//C�ǹ� �߰��� �ε��� ����

	}

	//�������
	//1.���̺��� ū ���� �Է��� ���

}
/// <summary>
/// ���� �����ϴ� �Լ�
/// </summary>
/// <param name="index"></param>
void RemoveAt(int index)
{
	//2. ���̳ʽ� �Է�
	if (index < 0)
	{
		printf("�ε��� ����\n");
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