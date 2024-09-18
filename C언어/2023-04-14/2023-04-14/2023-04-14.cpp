#include<stdio.h>

const int BOOK_MAX_COUNT = 6;

struct Book
{
	char title[20];
	char maker[20];
	int price;
	bool rent;
};

//���� å�� ��Ȳ
void Info(Book *bookshelf)
{

	for (int i = 0; i < BOOK_MAX_COUNT; i++)
	{
		if (bookshelf[i].title[0] == '\0')
		{
			printf("%d. �������\n", i + 1);
		}
		else
		{
			printf("%d. %s\n", i + 1, bookshelf[i].title);
		}
	}
}

//å �߰��ϴ� �Լ� �����
void Add(Book *bookshelf)
{
	printf("\n<<1. å �߰��ϱ�>>\n");
	Info(bookshelf); //����ִ� å�� ��Ȳ

	int shelf_num;

	printf("����ִ� å���� �����ϼ���: ");
	scanf_s("%d", &shelf_num);

	if (bookshelf[shelf_num -1].title[0] == '\0')
	{
		printf("�߰��� å�� ������ �Է��ϼ���: ");
		scanf_s("%s", &bookshelf[shelf_num - 1].title, 20);
		printf("�߰��� å�� ���ڸ� �Է��ϼ���: ");
		scanf_s("%s", &bookshelf[shelf_num - 1].maker, 20);
		printf("�߰��� å�� �ݾ��� �Է��ϼ���: ");
		scanf_s("%d", &bookshelf[shelf_num - 1].price);

		bookshelf[shelf_num].rent = false; //�߰��ϴ� å�̹Ƿ� �뿩�ƴ�
	}
	else
	{
		printf("�ٸ� å���� �������ֽʽÿ�.");
		return;
	}
	printf("å�� �߰��Ǿ����ϴ�.\n");
}



int main(void) 
{
	Book bookshelf[BOOK_MAX_COUNT];

	Book empty; //����ִ� å

	empty.title[0] = '\0';
	empty.maker[0] = '\0';
	empty.price = -1;
	empty.rent = false;

	for (int i = 0; i < BOOK_MAX_COUNT; i++)
	{
		bookshelf[i] = empty;
	}

	int choice;

	printf("���� ���� ���α׷� �Դϴ�.\n");
	printf("�޴��� �����ϼ���.\n");
	printf("1. å �߰��ϱ�\n");
	printf("2. å �����ϱ�\n");
	printf("3. å ���� Ȯ��\n");
	printf("4. å �˻�(����)\n");
	printf("5. å �뿩\n");
	printf("6. å �ݳ�\n");
	printf("7. ����\n\n");

	printf("�޴� ���� : ");
	scanf_s("%d", &choice);

	switch (choice)
	{

		case 1:
			Add(bookshelf);
			break;
		case 21:
			//�����ۼ�
			break;
		case 3:
			//�����ۼ�
			break;
		case 4:
			//�����ۼ�
			break;
		case 5:
			//�����ۼ�
			break;
		case 6:
			//�����ۼ�
			break;
		case 7:
			//�����ۼ�
			break;
		default:
			//�����ۼ�
			break;
	}
	printf("\n");
}




/*
int main(void)
{
	


	char name[13];

	printf("�̸��� �Է����ּ��� : ");
	scanf_s("%s", name,13);

	printf("����� �̸��� : %s �Դϴ�. ", name);



	char text[4] = "��";

	text[3] = 'd';


	printf("%c", text[0]);
	printf("%c", text[1]);
}
*/