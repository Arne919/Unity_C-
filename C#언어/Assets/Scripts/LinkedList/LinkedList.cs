using UnityEngine;

public class LinkedList
{

    Node head = null; //리스트의 첫번째 노드
    Node search = null; //탐색 노드

    /// <summary>
    /// 첫번째 노드로부터 마지막 노드에 새로운 노드를 추가
    /// </summary>
    /// <param name="num"></param>
    public void Add(int num)
    {
        Node newNode = new Node(); //새노드 생성
        newNode.data = num;
        newNode.next = null;

        if (head == null) //첫번째 노드가 비어 있을 때
        {
            head = newNode; //첫번째 노드에 새노드를 넣어줌
        }
        else //첫번째 노드가 존재 할 때
        {
            search = head; //마지막 노드를 찾기 위한 search 노드를 head로 만들어줌

            //search의 다음 노드가 비어 있을 경우 리스트의 마지막 노드
            //search의 다음 노드가 비어 있을 때까지 반복
            //search의 다음 노드가 비어 있다면 아래 문장을 실행하지 않고 while 루프 탈출
            //탈출 했을 시 현재 상태는 search.next = null 즉, 리스트의 마지막 노드는 search
            while (search.next != null)
            {
                search = search.next; //search의 다음 노드가 존재한다면 다음 노드를 이동
            }

            search.next = newNode; //search가 마지막 노드이기 때문에 search의 다음에 새로 생성한 노드를 생성
        }
    }
    public void Remove() //마지막 노드 제거
    {
        if (head == null) //리스트가 비어 있을 때
        {
            Debug.Log("삭제할 노드가 없습니다.");

        }
        else //리스트가 비어 있지 않을 때
        {
            if (head.next == null) //head만 들어 있을 때
            {
                head = null; //head 제거
            }
            else //head 다음에도 노드가 존재 할 때
            {
                search = head; //마지막을 찾기 위한 노드에 head를 넣어줌
                Node previous = null; //마지막 이전의 노드 생성

                //다은 노드가 없다면 마지막 노드이므로 다음 노드가 없을 때까지 반복
                //루프를 탈출 했을 때 while루프 안의 코드는 실행되지 않기 때문에 상태는
                //previous는 마지막 이전의 노드
                //previous.next는 마지막 노드 즉 search
                while (search.next != null)
                {
                    previous = search; //이전의 노드에 search를 넣고
                    search = search.next; //search에 그다음을 넣어서 이동을 반복
                }

                previous.next = null;
                //previous는 마지막 이전의 노드이기에 previous.next 마지막 노드를 가리키고 있다.
                //연결된 노드를 끊으려면 이전의 노드가 가리키고 있는 다음 노드를 null로 만들어야 한다.
            }
        }
    }
    public void RemoveAt(int index) //원하는 인덱스의 노드 제거
    {
        if (index < 0)
        {
            Debug.Log("유효하지 않은 인덱스입니다.");
            return; //유효성 검사
        }
        if (head == null) //리스트가 비어 있을 때
        {
            Debug.Log("노드가 존재하지 않습니다.");
            return; //함수 종료, 유효성 검사 끝
        }
        else //리스트가 비어있지 않을 때
        {
            if (index == 0)
            {
                head = head.next;
                return;
            }

            search = head; //제거할 노드를 찾는 search노드에 head를 넣어서 리스트의 처음부터 탐색
            Node previous = null; //제거하기 이전의 노드를 생성

            int searchIndex = 0; //리스트의 처음부터 원하는 index까지 반복할 횟수

            //index보다 작다면 반복
            //리스트의 index는 0부터 시작
            //예를 들어 index가 3이라면 리스트의 4번째 노드를 뜻하기 때문에
            //searchIndex가 0부터 시작해서 0,1,2에서 루프를 탈출하게 되고 이 상태에서
            //index 2(세번째)노드는 previous, index 3(네번째)노드는 search가 됨, 즉 search는 지우고

            while (searchIndex < index)
            {
                prevous = searchIndex; //생성한 이전의 노드에 현재의 노드를 넣고
                search = search.next; //현재의 노드는 다음의 노드를 가리킴
                searchIndex++; //다음 루프 진행

                //만약 루프 도중 search가 null이라면 리스트의 count보다 큰 index를 입력했으므로 종료
                if (search == null)
                {
                    Debug.Log("유효하지 않은 인덱스입니다.");
                    return;
                }

                //지우고자 하는 index 번호는 3이기 때문에 이전의 노드가 지우고자 하는 노드의 다음을 가리키게 된다.
                //현재 지우고자 하는 노드인 search를 null로 만들어준다.
                previous.next = search.next;
                search = null;
            }
        }
    }

    public void RemoveAll() //리스트 전체 제거
    {
        head = null; //첫번째 노드를 제거하면 다음 노드들이 참조할 노드가 없음
    }

    public void PrintAll() //리스트의 모든 노드들이 가지고 있는 데이터 출력
    {
        search = head; //탐색 노드에 리스트 첫번째 노드를 넣어줌

        if (head == null) //첫번째 노드가 비어있을 경우 함수 종료
        {
            Debug.Log("리스트가 비어있습니다.");
            return;
        }

        //탐색 노드가 비어있지 않다면 루프 반복
        //루프 안에서 다음 노드로 이동 할 때 비어 있다면 루프 탈출, 마지막 노드를 출력하고 탈출
        while (search != null)
        {
            Debug.Log(search.data); //데이터 출력
            search = search.next; //출력했다면 다음 노드로 이동
        }
    }

    public void Insert(int index, int num) //원하는 인덱스의 노드 추가
    {
        if (index < 0) //인덱스가 0보다 작을 경우 함수 종료
        {
            Debug.Log("유효하지 않은 인덱스입니다.");
            return;
        }

        Node newNode = new Node(); //추가할 새 노드 생성
        newNode.data = num; //새 노드에 data 추가

        if (head == null) //리스트의 첫번째 노드가 비어있을 때
        {
            if (index == 0) //index가 0이라면
            {
                head = newNode; //만들어 놓은 새노드를 head에 넣어줌
                head.next = null;
            }
            else //첫번째 노드가 비어있기 때문에 함수 종료
            {
                Debug.Log("유효하지 않은 인덱스입니다.");
            }
        }
        else //리스트에 노드가 있을 때
        {
            Node previous = null; //이전을 가리키는 노드

            search = head; //탐색 노드에 첫번째 노드를 넣어줌

            if (index == 0) //첫번째 노드에 새노드를 넣을 때
            {
                newNode.next = head; //새노드의 다음을 기존의 head를 가리키게 하고
                head = newNode; //첫번째 노드에 새노드를 넣어줌
                return; //아래 코드들이 실행되지 않도록 함수 종료
            }

            int searchIndex = 0; //반복 횟수 비교

            //반복 횟수가 원하는 index의 숫자와 같아지면 루프 탈출
            //탈출 했을 경우 현재 노드 상태는 원하는 index의 노드는 search, 그 이전의 노드는 previous
            while (searchIndex < index)
            {
                previous = search; //이전의 노드가 현재 탐색 노드가 되고
                search = search.next; //현재 탐색 노드가 다믕 노드로 이동
                searchIndex++; //다음 루프 진행
            }

            //넣고자 하는 위치의 노드가 search 이므로 그이전의 previous 노드가
            //추가할 새 노드를 가르키게 연결
            previous.next = newNode;
            newNode.next = search; //추가한 새노드의 다음을 기존의 index에 있던 search 노드와 연결
        }
    }

    public class Node
    {
        public int data; //노드의 값
        public Node next = null; //다음 노드 주소
    }
}
    