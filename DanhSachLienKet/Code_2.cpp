#include<iostream>

/* 
    1.Tạo danh sách liên kết:
    Lần lượt nhập vào các số nguyên kết thúc khi gõ 0. Các số nguyên nhập vào được tổ chức thành
    1 cây nhị phân tìm kiếm.

    *Duyệt cây: Đi qua tất cả các nút của cây, mỗi nút chỉ xử lí 1 lần...
    Căn cứ vào thứ tự xử lí nút gốc so với cây con trái, phải chia phép duyệt:
    - Duyệt cây theo thứ tự trước:
        + NLR
        + NRL
    - Duyệt theo thứ tự giữa:
        + LNR
        +RNR
    - Duyệt theo thứ tự sau:
        + LRN
        + RLN

    1. Xét 1 phép duyệt cây: in ra giá trị của nút
    2. Tính tổng các nút
    3. Tính tổng nút lẻ
    4. Đếm số nút lá
    5. Đếm các nút có cây con phải không có cây con trái

*/

struct nut
{
    int Info;
    nut *left;
    nut * right;
};

typedef nut Node;
Node *goc;

void khoitao(Node *&goc)
{
    goc==NULL;
}

void mocnut(Node *&goc, int X)
{
    // Moc nut co gia tri X vao cay nhi phan tim kiem
    if (goc==NULL)
    {
        goc=new Node;
        goc->Info=X;
        goc->left=NULL;
        goc->right=NULL;
    }else if
        (goc->Info>=X)
        mocnut(goc->left,X);
    else
        mocnut(goc->right,X);   
}
// Tao cay
void taocay(Node *&goc)
{
    int tam;
    do
    {
        printf("\n Nhap 1 so nguyen, 0:dung ");
        scanf("%d", &tam);
        if(tam!=0)
            mocnut(goc,tam);
    } while (tam!=0);
}

void LNR(Node *goc)
{
    if (goc!=NULL)
    {
            LNR(goc->left);
            printf("%3d", goc->Info);
            LNR(goc->right);
    }
}

void NLR(Node *goc)
{
    if (goc!=NULL)
    {
        printf("%3d", goc->Info);
        NLR(goc->left);
        NLR(goc->right);
    }
    
}

int tongnut(Node *goc)
{
    if(goc==NULL) return 0;
    else
    return goc->Info+tongnut(goc->left)+tongnut(goc->right);
}

int tongle(Node *goc)
{
    if(goc==NULL) return 0;
    else
        if(goc->Info % 2 != 0)
            return goc->Info+tongle(goc->left)+tongle(goc->right);
        else
            return tongle(goc->left)+tongle(goc->right);
}

int demla(Node *goc)
{
    if(goc==NULL) return 0;
    else
        if (goc->left==NULL && goc->right==NULL)
            return 1;
        else
            return demla(goc->left)+demla(goc->right);
}

int demnutpkt(Node *goc)
{
    if(goc==NULL) return 0;
        else 
            if(goc->left==NULL && goc->right==NULL) return 0;
                else
                    if (goc->left==NULL && goc->right!=NULL)
                        return 1+ demnutpkt(goc->right);
                    else
                        return demnutpkt(goc->left)+demnutpkt(goc->right);
                    
}

int main()
{
    khoitao(goc);
    taocay(goc);
    printf("\n Duyet cay theo thu tu LNR: \n");
    LNR(goc);
    printf("\n Tong cac nut %d \n", tongnut(goc));
    printf("\n Tong cac nut le %d \n ", tongle(goc));
    printf("\n So nut la %d\n", demla(goc));
    printf("\n So nut co phai khong trai %d\n", demnutpkt(goc));
    //printf("\n Duyet cay theo thu tu NLR: \n");
    //NLR(goc);
    return 0;
}



