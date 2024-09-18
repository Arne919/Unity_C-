#include<stdio.h>

const int BOOK_MAX_COUNT = 6;

struct Book
{
	char title[20];
	char maker[20];
	int price;
	bool rent;
};

//현재 책장 현황
void Info(Book *bookshelf)
{

	for (int i = 0; i < BOOK_MAX_COUNT; i++)
	{
		if (bookshelf[i].title[0] == '\0')
		{
			printf("%d. 비어있음\n", i + 1);
		}
		else
		{
			printf("%d. %s\n", i + 1, bookshelf[i].title);
		}
	}
}

//책 추가하는 함수 만들기
void Add(Book *bookshelf)
{
	printf("\n<<1. 책 추가하기>>\n");
	Info(bookshelf); //비어있는 책장 현황

	int shelf_num;

	printf("비어있는 책장을 선택하세요: ");
	scanf_s("%d", &shelf_num);

	if (bookshelf[shelf_num -1].title[0] == '\0')
	{
		printf("추가할 책의 제목을 입력하세요: ");
		scanf_s("%s", &bookshelf[shelf_num - 1].title, 20);
		printf("추가할 책의 저자를 입력하세요: ");
		scanf_s("%s", &bookshelf[shelf_num - 1].maker, 20);
		printf("추가할 책의 금액을 입력하세요: ");
		scanf_s("%d", &bookshelf[shelf_num - 1].price);

		bookshelf[shelf_num].rent = false; //추가하는 책이므로 대여아님
	}
	else
	{
		printf("다른 책장을 선택해주십시오.");
		return;
	}
	printf("책이 추가되었습니다.\n");
}



int main(void) 
{
	Book bookshelf[BOOK_MAX_COUNT];

	Book empty; //비어있는 책

	empty.title[0] = '\0';
	empty.maker[0] = '\0';
	empty.price = -1;
	empty.rent = false;

	for (int i = 0; i < BOOK_MAX_COUNT; i++)
	{
		bookshelf[i] = empty;
	}

	int choice;

	printf("도서 관리 프로그램 입니다.\n");
	printf("메뉴를 선택하세요.\n");
	printf("1. 책 추가하기\n");
	printf("2. 책 삭제하기\n");
	printf("3. 책 정보 확인\n");
	printf("4. 책 검색(유무)\n");
	printf("5. 책 대여\n");
	printf("6. 책 반납\n");
	printf("7. 종료\n\n");

	printf("메뉴 선택 : ");
	scanf_s("%d", &choice);

	switch (choice)
	{

		case 1:
			Add(bookshelf);
			break;
		case 21:
			//내용작성
			break;
		case 3:
			//내용작성
			break;
		case 4:
			//내용작성
			break;
		case 5:
			//내용작성
			break;
		case 6:
			//내용작성
			break;
		case 7:
			//내용작성
			break;
		default:
			//내용작성
			break;
	}
	printf("\n");
}




/*
int main(void)
{
	


	char name[13];

	printf("이름을 입력해주세요 : ");
	scanf_s("%s", name,13);

	printf("당신의 이름은 : %s 입니다. ", name);



	char text[4] = "가";

	text[3] = 'd';


	printf("%c", text[0]);
	printf("%c", text[1]);
}
*/