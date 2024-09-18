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

//현재 책장 현황
void Info(Book* bookshelf)
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
	printf("\n");
}

//책 추가하는 함수
void Add(Book* bookshelf)
{
	printf("\n<<1. 책 추가하기>>\n");
	Info(bookshelf); //비어있는 책장 현황

	int shelf_num;

	printf("비어있는 책장을 선택하세요: ");
	scanf_s("%d", &shelf_num);

	if (bookshelf[shelf_num - 1].title[0] == '\0')
	{
		printf("추가할 책의 제목을 입력하세요: ");
		scanf_s("%s", bookshelf[shelf_num - 1].title, BOOK_TITLE_LENGTH);
		printf("추가할 책의 저자를 입력하세요: ");
		scanf_s("%s", bookshelf[shelf_num - 1].maker, BOOK_TITLE_LENGTH);
		printf("추가할 책의 금액을 입력하세요: ");
		scanf_s("%d", &bookshelf[shelf_num - 1].price);

		bookshelf[shelf_num-1].rent = false; //추가하는 책이므로 대여아님
	}
	else
	{
		printf("다른 책장을 선택해주십시오.");
		return;
	}
	printf("\n책이 추가되었습니다.\n");
	Info(bookshelf);
}

/// <summary>
/// 책 삭제하는 함수
/// </summary>
/// <param name="bookshelf"></param>
void Delete(Book* bookshelf)
{
	int shelf_num;
	Info(bookshelf);

	printf("<<2. 책 삭제하기>>\n");
	printf("삭제할 책을 선택하세요: ");
	scanf_s("%d", &shelf_num);
	//삭제할지 if
	if (bookshelf[shelf_num - 1].title[0] != '\0')
	{
		int answer;

		printf("정말로 삭제 하시겠습니까? (1. 네 / 2. 아니오): ");
		scanf_s("%d",&answer);

		if (answer == 1)
		{
			bookshelf[shelf_num - 1].title[0] = '\0';
			bookshelf[shelf_num - 1].maker[0] = '\0';
			bookshelf[shelf_num - 1].price = -1;
			bookshelf[shelf_num - 1].rent = false;

			printf("\n 삭제가 완료되었습니다.\n");
		}
		else
		{
			printf("취소되었습니다.\n");
		}
	}
	else 
	{
		printf("삭제할 책이 없습니다.");
		return;
	}
	Info(bookshelf);
};
/// <summary>
/// 책장번호 검색하면 책의 정보를 알려주는 함수
/// </summary>
/// <param name="bookshelf"></param>
void Check(Book* bookshelf)
{
	int shelf_num; 

	Info(bookshelf); //책장 현황
	printf("확인하고 싶은 책의 책장번호를 입력하세요: ");
	scanf_s("%d", &shelf_num);
	
	printf("제목: %s\n", bookshelf[shelf_num - 1].title, BOOK_TITLE_LENGTH);
	printf("저자: %s\n", bookshelf[shelf_num - 1].maker, BOOK_TITLE_LENGTH);
	printf("가격: %d\n", bookshelf[shelf_num - 1].price);


}

////덜했음
//void Search(Book* bookshelf)
//{
//	int shelf_num;
//	char book[BOOK_TITLE_LENGTH]; //검색할 책
//
//	printf("책을 검색하세요: ");
//	scanf_s("%c", &book, BOOK_TITLE_LENGTH);
//
//	bool compare = false;
//	
//	for (int i = 0; i < BOOK_MAX_COUNT; i++)
//	{
//		if (book[BOOK_TITLE_LENGTH] != bookshelf[shelf_num].title[i]
//			bookshelf[shelf_num - 1].title[i])
//		{
//			printf("다시 검색하세요\n");
//		}
//		else
//		{
//			if (book == '\0')
//			{
//				compare = true;
//				printf("일치합니다.");
//				printf("제목: %s\n", bookshelf[shelf_num - 1].title, BOOK_TITLE_LENGTH);
//				printf("저자: %s\n", bookshelf[shelf_num - 1].maker, BOOK_TITLE_LENGTH);
//				printf("가격: %d\n", bookshelf[shelf_num - 1].price);
//				return;
//			}
//		}
//	}
//}

int Borrow(Book* bookshelf) 
{
	// 사용자로 부터 책번호를 받을 변수
	int shelf_num;
	Info(bookshelf);

	printf("빌릴 책의 번호를 말해주세요. \n");
	printf("책 번호 : ");
	scanf_s("%d", &shelf_num);

	//빈책장은 다시고르도록....수정해야함
	if (bookshelf[shelf_num-1].rent == 1) 
	{
		printf("이미 대출된 책입니다! \n");
	}
	else 
	{
		printf("책이 성공적으로 대출되었습니다. \n");
		bookshelf[shelf_num-1].rent = 1;
	}

	return 0;
}

int Return(Book* bookshelf)
{
	// 반납할 책의 번호 
	int shelf_num;

	printf("반납할 책의 번호를 써주세요 \n");
	printf("책 번호 : ");
	scanf_s("%d", &shelf_num);

	if (bookshelf[shelf_num-1].rent == 0)
	{
		printf("이미 반납되어 있는 상태입니다\n");
	}
	else 
	{
		bookshelf[shelf_num-1].rent = 0;
		printf("성공적으로 반납되었습니다\n");
	}

	return 0;
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
	case 2:
		Delete(bookshelf);
		break;
	case 3:
		Check(bookshelf);
		break;
	case 4:
		//미완료
		break;
	case 5:
		Borrow(bookshelf);
		break;
	case 6:
		Return(bookshelf);
		break;
	case 7:
		printf("도서 관리 프로그램을 종료합니다.");
		return 0;
	default:
		printf("1~7번 메뉴를 골라주세요.");
		break;
	}
	printf("\n");
	return 0;
}