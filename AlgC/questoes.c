/*struct array_list{
int *data;
unsigned int size;
unsigned int capacity;
};

void array_list_increase_capacity(struct array_list *list){
    if(list->size == list->capacity){
        struct array_list new_list;
        new_list.capacity = (int *)malloc(sizeof((list->capacity+10)));

        for(int i=0; i<list->size; i++){
            new_list.data[i] = list->data[i];
        } 
        free(*list);
        *list = new_list;
    }
}*/

// int main(){
//     struct array_list teste;

// }

// 4 - D

/*void swap (int *a, int *b){  QUESTAO 3
    int aux=0;
    aux = *b;
    *b = *a;
    *a = aux;
}


int main(){
    int x=10, y=20;
    swap(&x, &y);
    printf("%d, %d", x, y);
    return 0;
}/*


/*int main() {
int a = 10, b = 20, c = 30;
int *ponteiro;
ponteiro = &b;
*ponteiro = *ponteiro + 1;
*ponteiro = 50;
printf("a,b,c = %d, %d, %d\n",a,b,c);
return 0;
}*/


/*int main(){
int a=10,b=20;
int *pa, *pb;
pa = &a;
pb = &b;
*pa = *pb * 2;
printf("%d,%d\n",a,b);
return 0;
}*/
