#include<stdio.h>

const int BOOK_MAX_COUNT = 6;
const int BOOK_TITLE_LENGTH = 20;

struct Book
{
	char title[20];
	char maker[20];
	int price;
	bool rent;
};

//���� å�� ��Ȳ
void Info(Book* bookshelf)
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
	printf("\n");
}

//å �߰��ϴ� �Լ�
void Add(Book* bookshelf)
{
	printf("\n<<1. å �߰��ϱ�>>\n");
	Info(bookshelf); //����ִ� å�� ��Ȳ

	int shelf_num;

	printf("����ִ� å���� �����ϼ���: ");
	scanf_s("%d", &shelf_num);

	if (bookshelf[shelf_num - 1].title[0] == '\0')
	{
		printf("�߰��� å�� ������ �Է��ϼ���: ");
		scanf_s("%s", bookshelf[shelf_num - 1].title, BOOK_TITLE_LENGTH);
		printf("�߰��� å�� ���ڸ� �Է��ϼ���: ");
		scanf_s("%s", bookshelf[shelf_num - 1].maker, BOOK_TITLE_LENGTH);
		printf("�߰��� å�� �ݾ��� �Է��ϼ���: ");
		scanf_s("%d", &bookshelf[shelf_num - 1].price);

		bookshelf[shelf_num-1].rent = false; //�߰��ϴ� å�̹Ƿ� �뿩�ƴ�
	}
	else
	{
		printf("�ٸ� å���� �������ֽʽÿ�.");
		return;
	}
	printf("\nå�� �߰��Ǿ����ϴ�.\n");
	Info(bookshelf);
}

/// <summary>
/// å �����ϴ� �Լ�
/// </summary>
/// <param name="bookshelf"></param>
void Delete(Book* bookshelf)
{
	int shelf_num;
	Info(bookshelf);

	printf("<<2. å �����ϱ�>>\n");
	printf("������ å�� �����ϼ���: ");
	scanf_s("%d", &shelf_num);
	//�������� if
	if (bookshelf[shelf_num - 1].title[0] != '\0')
	{
		int answer;

		printf("������ ���� �Ͻðڽ��ϱ�? (1. �� / 2. �ƴϿ�): ");
		scanf_s("%d",&answer);

		if (answer == 1)
		{
			bookshelf[shelf_num - 1].title[0] = '\0';
			bookshelf[shelf_num - 1].maker[0] = '\0';
			bookshelf[shelf_num - 1].price = -1;
			bookshelf[shelf_num - 1].rent = false;

			printf("\n ������ �Ϸ�Ǿ����ϴ�.\n");
		}
		else
		{
			printf("��ҵǾ����ϴ�.\n");
		}
	}
	else 
	{
		printf("������ å�� �����ϴ�.");
		return;
	}
	Info(bookshelf);
};
/// <summary>
/// å���ȣ �˻��ϸ� å�� ������ �˷��ִ� �Լ�
/// </summary>
/// <param name="bookshelf"></param>
void Check(Book* bookshelf)
{
	int shelf_num; 

	Info(bookshelf); //å�� ��Ȳ
	printf("Ȯ���ϰ� ���� å�� å���ȣ�� �Է��ϼ���: ");
	scanf_s("%d", &shelf_num);
	
	printf("����: %s\n", bookshelf[shelf_num - 1].title, BOOK_TITLE_LENGTH);
	printf("����: %s\n", bookshelf[shelf_num - 1].maker, BOOK_TITLE_LENGTH);
	printf("����: %d\n", bookshelf[shelf_num - 1].price);


}

////������
//void Search(Book* bookshelf)
//{
//	int shelf_num;
//	char book[BOOK_TITLE_LENGTH]; //�˻��� å
//
//	printf("å�� �˻��ϼ���: ");
//	scanf_s("%c", &book, BOOK_TITLE_LENGTH);
//
//	bool compare = false;
//	
//	for (int i = 0; i < BOOK_MAX_COUNT; i++)
//	{
//		if (book[BOOK_TITLE_LENGTH] != bookshelf[shelf_num].title[i]
//			bookshelf[shelf_num - 1].title[i])
//		{
//			printf("�ٽ� �˻��ϼ���\n");
//		}
//		else
//		{
//			if (book == '\0')
//			{
//				compare = true;
//				printf("��ġ�մϴ�.");
//				printf("����: %s\n", bookshelf[shelf_num - 1].title, BOOK_TITLE_LENGTH);
//				printf("����: %s\n", bookshelf[shelf_num - 1].maker, BOOK_TITLE_LENGTH);
//				printf("����: %d\n", bookshelf[shelf_num - 1].price);
//				return;
//			}
//		}
//	}
//}

int Borrow(Book* bookshelf) 
{
	// ����ڷ� ���� å��ȣ�� ���� ����
	int shelf_num;
	Info(bookshelf);

	printf("���� å�� ��ȣ�� �����ּ���. \n");
	printf("å ��ȣ : ");
	scanf_s("%d", &shelf_num);

	//��å���� �ٽð�����....�����ؾ���
	if (bookshelf[shelf_num-1].rent == 1) 
	{
		printf("�̹� ����� å�Դϴ�! \n");
	}
	else 
	{
		printf("å�� ���������� ����Ǿ����ϴ�. \n");
		bookshelf[shelf_num-1].rent = 1;
	}

	return 0;
}

int Return(Book* bookshelf)
{
	// �ݳ��� å�� ��ȣ 
	int shelf_num;

	printf("�ݳ��� å�� ��ȣ�� ���ּ��� \n");
	printf("å ��ȣ : ");
	scanf_s("%d", &shelf_num);

	if (bookshelf[shelf_num-1].rent == 0)
	{
		printf("�̹� �ݳ��Ǿ� �ִ� �����Դϴ�\n");
	}
	else 
	{
		bookshelf[shelf_num-1].rent = 0;
		printf("���������� �ݳ��Ǿ����ϴ�\n");
	}

	return 0;
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
	case 2:
		Delete(bookshelf);
		break;
	case 3:
		Check(bookshelf);
		break;
	case 4:
		//�̿Ϸ�
		break;
	case 5:
		Borrow(bookshelf);
		break;
	case 6:
		Return(bookshelf);
		break;
	case 7:
		printf("���� ���� ���α׷��� �����մϴ�.");
		return 0;
	default:
		printf("1~7�� �޴��� ����ּ���.");
		break;
	}
	printf("\n");
	return 0;
}