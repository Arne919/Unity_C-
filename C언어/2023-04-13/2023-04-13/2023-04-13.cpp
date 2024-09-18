#include<stdio.h>

struct Vector3
{
	float x;
	float y;
	float z;
};

//position   scale  rotatiton
//위치       크기   회전
struct Transform
{
	Vector3 position;
	Vector3 scale;
	Vector3 rotation;
};

int main(void)
{
	Transform t;
	Vector3 startPos;
	startPos.x = 10;
	startPos.y = 20;
	startPos.z = 30;

	t.position = startPos;



	/*t.position.x = 0;
	t.position.y = 1;
	t.position.y = 2;

	t.scale.x = 1;
	t.scale.y = 1;
	t.scale.z = 1;

	t.rotation.x = 1;
	t.rotation.y = 1;
	t.rotation.z = 1;*/
	

}