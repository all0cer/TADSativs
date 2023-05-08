#include <stdio.h>
#include <stdlib.h>
#include "linked_list.h"

struct linked_list_node{
int value;
struct linked_list_node *next;
};


struct linked_list{
struct linked_list_node *first, *last;
};


/* Cria e retorna uma nova lista com 0 elementos.
Se a lista não for criada retorna NULL (0) */
struct linked_list * ll_create(){
struct linked_list * new_list;
new_list = (struct linked_list*)malloc(sizeof(struct linked_list));
    if (new_list != 0){
        new_list->first=0;
        new_list->last=0;
}
return new_list;
}
/* Inserir no início da lista */
void ll_push_back(linked_list list, int value){
            struct linked_list_node *new_node;
            new_node = (struct linked_list_node*)malloc(sizeof(struct linked_list_node));
            new_node->value = value;
            new_node->next = 0;
            if (list->first == 0){
                list->first = new_node;
            } 
            else{
                list->last->next = new_node;
            }
            list->last = new_node;

}


void ll_push_front(linked_list list, int value){
            struct linked_list_node *new_node;
            new_node = (struct linked_list_node*)malloc(sizeof(struct linked_list_node));
            new_node->value = value;
            if (list->first == 0){
                list->first = new_node;
                new_node->next = 0;
                list->last = new_node;
            } 
            else{
            new_node->next = list->first;
            list->first = new_node;
            }

}
/* Imprime a lista */
void print_ll(struct linked_list *list){
    struct linked_list_node *atual= list->first;
    while(atual != 0){
        printf ("%d -> ", atual->value);
        atual = atual->next;
    }
    printf("0");
}
unsigned long long ll_size(linked_list list){
    long long cont;
    struct linked_list_node *novo = list->first;
    while(novo->next != 0){
        novo = novo->next;
        cont++;
    }
    return cont;
}


int main(){
    linked_list list1;
    list1 = ll_create();
    int x;
    while(x != -1){
        scanf("%d", &x);
        ll_push_front(list1, x);
    }
    print_ll(list1);
    ll_push_back(list1, 28);
    printf("\n");
    print_ll(list1);
    printf("\n%d", ll_size(list1));

}