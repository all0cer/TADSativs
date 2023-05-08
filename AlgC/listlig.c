#include <stdio.h>
#include <stdlib.h>


    struct ll_int_no{
    int value;
    struct ll_int_no *next;
    };

struct ll_int_no *ll_int_appendi(struct ll_int_no *first, int x){
    struct ll_int_no *new_node = (struct ll_int_no*) malloc(sizeof(struct ll_int_no));//Libera espaço de memória para um valor inteiro  e um no
    new_node->value = x; //Atribui valor
    new_node->next = first; //Aponta para vazio (se torna o ultimo no)
    first = new_node; // Aponta para o primeiro no criado
    return first;
}

void print_ll(struct ll_int_no *atual){
    struct ll_int_no *atual=first;
    while(atual != 0){
        printf ("%d -> ", *atual);
        atual = atual->next;
    }
    printf("0");
}

int main(){
    struct ll_int_no *first=0;
    first = ll_int_appendi(first, 5);
    first = ll_int_appendi(first, 6);
    first = ll_int_appendi(first, 8);
    first = ll_int_appendi(first, 10);

    struct ll_int_no *current=first;
    print_ll(current);
    return 0;

}