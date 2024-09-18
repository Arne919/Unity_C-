using UnityEngine;

public class LinkedList
{

    Node head = null; //����Ʈ�� ù��° ���
    Node search = null; //Ž�� ���

    /// <summary>
    /// ù��° ���κ��� ������ ��忡 ���ο� ��带 �߰�
    /// </summary>
    /// <param name="num"></param>
    public void Add(int num)
    {
        Node newNode = new Node(); //����� ����
        newNode.data = num;
        newNode.next = null;

        if (head == null) //ù��° ��尡 ��� ���� ��
        {
            head = newNode; //ù��° ��忡 ����带 �־���
        }
        else //ù��° ��尡 ���� �� ��
        {
            search = head; //������ ��带 ã�� ���� search ��带 head�� �������

            //search�� ���� ��尡 ��� ���� ��� ����Ʈ�� ������ ���
            //search�� ���� ��尡 ��� ���� ������ �ݺ�
            //search�� ���� ��尡 ��� �ִٸ� �Ʒ� ������ �������� �ʰ� while ���� Ż��
            //Ż�� ���� �� ���� ���´� search.next = null ��, ����Ʈ�� ������ ���� search
            while (search.next != null)
            {
                search = search.next; //search�� ���� ��尡 �����Ѵٸ� ���� ��带 �̵�
            }

            search.next = newNode; //search�� ������ ����̱� ������ search�� ������ ���� ������ ��带 ����
        }
    }
    public void Remove() //������ ��� ����
    {
        if (head == null) //����Ʈ�� ��� ���� ��
        {
            Debug.Log("������ ��尡 �����ϴ�.");

        }
        else //����Ʈ�� ��� ���� ���� ��
        {
            if (head.next == null) //head�� ��� ���� ��
            {
                head = null; //head ����
            }
            else //head �������� ��尡 ���� �� ��
            {
                search = head; //�������� ã�� ���� ��忡 head�� �־���
                Node previous = null; //������ ������ ��� ����

                //���� ��尡 ���ٸ� ������ ����̹Ƿ� ���� ��尡 ���� ������ �ݺ�
                //������ Ż�� ���� �� while���� ���� �ڵ�� ������� �ʱ� ������ ���´�
                //previous�� ������ ������ ���
                //previous.next�� ������ ��� �� search
                while (search.next != null)
                {
                    previous = search; //������ ��忡 search�� �ְ�
                    search = search.next; //search�� �״����� �־ �̵��� �ݺ�
                }

                previous.next = null;
                //previous�� ������ ������ ����̱⿡ previous.next ������ ��带 ����Ű�� �ִ�.
                //����� ��带 �������� ������ ��尡 ����Ű�� �ִ� ���� ��带 null�� ������ �Ѵ�.
            }
        }
    }
    public void RemoveAt(int index) //���ϴ� �ε����� ��� ����
    {
        if (index < 0)
        {
            Debug.Log("��ȿ���� ���� �ε����Դϴ�.");
            return; //��ȿ�� �˻�
        }
        if (head == null) //����Ʈ�� ��� ���� ��
        {
            Debug.Log("��尡 �������� �ʽ��ϴ�.");
            return; //�Լ� ����, ��ȿ�� �˻� ��
        }
        else //����Ʈ�� ������� ���� ��
        {
            if (index == 0)
            {
                head = head.next;
                return;
            }

            search = head; //������ ��带 ã�� search��忡 head�� �־ ����Ʈ�� ó������ Ž��
            Node previous = null; //�����ϱ� ������ ��带 ����

            int searchIndex = 0; //����Ʈ�� ó������ ���ϴ� index���� �ݺ��� Ƚ��

            //index���� �۴ٸ� �ݺ�
            //����Ʈ�� index�� 0���� ����
            //���� ��� index�� 3�̶�� ����Ʈ�� 4��° ��带 ���ϱ� ������
            //searchIndex�� 0���� �����ؼ� 0,1,2���� ������ Ż���ϰ� �ǰ� �� ���¿���
            //index 2(����°)���� previous, index 3(�׹�°)���� search�� ��, �� search�� �����

            while (searchIndex < index)
            {
                prevous = searchIndex; //������ ������ ��忡 ������ ��带 �ְ�
                search = search.next; //������ ���� ������ ��带 ����Ŵ
                searchIndex++; //���� ���� ����

                //���� ���� ���� search�� null�̶�� ����Ʈ�� count���� ū index�� �Է������Ƿ� ����
                if (search == null)
                {
                    Debug.Log("��ȿ���� ���� �ε����Դϴ�.");
                    return;
                }

                //������� �ϴ� index ��ȣ�� 3�̱� ������ ������ ��尡 ������� �ϴ� ����� ������ ����Ű�� �ȴ�.
                //���� ������� �ϴ� ����� search�� null�� ������ش�.
                previous.next = search.next;
                search = null;
            }
        }
    }

    public void RemoveAll() //����Ʈ ��ü ����
    {
        head = null; //ù��° ��带 �����ϸ� ���� ������ ������ ��尡 ����
    }

    public void PrintAll() //����Ʈ�� ��� ������ ������ �ִ� ������ ���
    {
        search = head; //Ž�� ��忡 ����Ʈ ù��° ��带 �־���

        if (head == null) //ù��° ��尡 ������� ��� �Լ� ����
        {
            Debug.Log("����Ʈ�� ����ֽ��ϴ�.");
            return;
        }

        //Ž�� ��尡 ������� �ʴٸ� ���� �ݺ�
        //���� �ȿ��� ���� ���� �̵� �� �� ��� �ִٸ� ���� Ż��, ������ ��带 ����ϰ� Ż��
        while (search != null)
        {
            Debug.Log(search.data); //������ ���
            search = search.next; //����ߴٸ� ���� ���� �̵�
        }
    }

    public void Insert(int index, int num) //���ϴ� �ε����� ��� �߰�
    {
        if (index < 0) //�ε����� 0���� ���� ��� �Լ� ����
        {
            Debug.Log("��ȿ���� ���� �ε����Դϴ�.");
            return;
        }

        Node newNode = new Node(); //�߰��� �� ��� ����
        newNode.data = num; //�� ��忡 data �߰�

        if (head == null) //����Ʈ�� ù��° ��尡 ������� ��
        {
            if (index == 0) //index�� 0�̶��
            {
                head = newNode; //����� ���� ����带 head�� �־���
                head.next = null;
            }
            else //ù��° ��尡 ����ֱ� ������ �Լ� ����
            {
                Debug.Log("��ȿ���� ���� �ε����Դϴ�.");
            }
        }
        else //����Ʈ�� ��尡 ���� ��
        {
            Node previous = null; //������ ����Ű�� ���

            search = head; //Ž�� ��忡 ù��° ��带 �־���

            if (index == 0) //ù��° ��忡 ����带 ���� ��
            {
                newNode.next = head; //������� ������ ������ head�� ����Ű�� �ϰ�
                head = newNode; //ù��° ��忡 ����带 �־���
                return; //�Ʒ� �ڵ���� ������� �ʵ��� �Լ� ����
            }

            int searchIndex = 0; //�ݺ� Ƚ�� ��

            //�ݺ� Ƚ���� ���ϴ� index�� ���ڿ� �������� ���� Ż��
            //Ż�� ���� ��� ���� ��� ���´� ���ϴ� index�� ���� search, �� ������ ���� previous
            while (searchIndex < index)
            {
                previous = search; //������ ��尡 ���� Ž�� ��尡 �ǰ�
                search = search.next; //���� Ž�� ��尡 �ْ� ���� �̵�
                searchIndex++; //���� ���� ����
            }

            //�ְ��� �ϴ� ��ġ�� ��尡 search �̹Ƿ� �������� previous ��尡
            //�߰��� �� ��带 ����Ű�� ����
            previous.next = newNode;
            newNode.next = search; //�߰��� ������� ������ ������ index�� �ִ� search ���� ����
        }
    }

    public class Node
    {
        public int data; //����� ��
        public Node next = null; //���� ��� �ּ�
    }
}
    