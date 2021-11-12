/*  1 Tạo danh sách:
    Lần lượt nhập các số nguyên từ bàn phím, kết thúc gõ 0; các số nguyên nhập vào lưu thành 1 ds lk đơn.
    2 Duyệt danh sách:
    đi qua tất cả các nút, mỗi nút xử lí 1 lần
    - in ra giá trị tất cả các nút.
    - tính tổng các nứt của danh sách
    - tính tổng các nút mang giá trị lẻ(lặp, đệ qui);
    3 Bổ sung 1 nút vào danh sách
    - Bổ sung 1 nút mang giá trị X vào đầu danh sách.
    - Chèn 1 nút vào cuối danh sách. (bài tập = đệ qui);
    - Chèn sau:
        Chèn một nút mang giá trị là X vào sau nút mang giá trị Y(nếu có)
    4 xóa nút:
    - Xóa nút đầu ds
    - Xóa nút cuối ds
    - Xóa nút đứng sau nút X
    5 xóa nút mang giá trị X
    6 xóa nút đứng trước nút mang giá trị X
    - Sắp xếp danh sách liên kết.
    - Đảo ngược danh sách liên kết.
    a Tạo danh sách mới.
    b Không tạo danh sách mới.
    
    7 Mở rộng danh sách liên kết
    - Danh sách liên kết kép
    - Danh sách liên kết vòng
    - Danh sách đa liên kết

*/
#include <stdio.h>
//--------------------------------------
struct nut{
	int gtri;
	nut *tiep;
};
typedef nut Node;
Node *dau, *daumoi;

void khoitao(Node *&dau){
	dau=NULL;
}
//----------------------------------------
void nhapds(Node *&dau)
{ Node *p;  // Chua d/c cu nut tao ra
  Node *q;  // Chua d/c nut cuoi ds
    q=NULL;
  int tam; // Chua so nguyen nhap
  do {
  	printf("\n Nhap 1 so nguyen, 0:dung ");
  	scanf("%d",&tam);
  	if (tam!=0)
  	{ // Tao nut moi
  	    p=new Node;
  	    p->gtri=tam;
  	    p->tiep=NULL;
  	  // Moc nut vao danh sach
		if (dau==NULL) // p la nut dau tien
		    dau=p;
		else
		  q->tiep=p;
		   q=p;	 
	 }
  }
  while (tam!=0);
}
//----------------------------------------------
void duyetlap(Node *dau)
{Node *p;
    p=dau;
    printf("\n");
    while (p!=NULL)
    { printf("%3d",p->gtri);
      p=p->tiep;
	}
}
//---------------------------------------------
void duyetdq(Node *dau)
{ if (dau!=NULL)
   { printf("%3d",dau->gtri);
     duyetdq(dau->tiep);
   }
}
//---------------------------------------------
int tonglap(Node *dau)
{ int s=0;
  Node *p =dau;
     while (p!=NULL)
	  { s=s+p->gtri;
	    p=p->tiep;
		}  
	return s;	
}
//----------------------------------------------
int tongdq(Node *dau)
{ if (dau==NULL)
   return 0;
  else
   return dau->gtri + tongdq(dau->tiep); 
}
//----------------------------------------------
int tonglel(Node *dau)
{int s=0;
 Node *p=dau;
    while (p!=NULL)
     {if (p->gtri %2 !=0)
        s=s+p->gtri;
        p=p->tiep;
	 }
	 return s;
}
//----------------------------------------------
int tongledq(Node *dau)
{ if (dau==NULL)
    return 0;
  else
     if (dau->gtri%2 !=0)
	   return dau->gtri + tongledq(dau->tiep);
	 else
	   return tongledq(dau->tiep);  
}
//----------------------------------------------
void chendau(Node *&dau,int X)
{ Node *p;
      p=new Node;
      p->gtri = X;
      p->tiep = dau;
      dau =p;
}
//----------------------------------------------
void chencuoi(Node *&dau, int X)
{ Node *p,*q;
   if (dau==NULL)
     chendau(dau,X);
   else
   {   q=dau;
      while (q->tiep !=NULL)
       q=q->tiep;
       p=new Node;
       p->gtri=X;
       p->tiep=NULL;
       q->tiep =p;
	 }  
}
//----------------------------------------------
void chensau(Node *&dau, int X, int Y)
{ Node *q, *p;
    // Tim nut mang gia tri Y
      q=dau;
       while ((q!=NULL)&&(q->gtri!=Y))
       q=q->tiep;
       if (q!=NULL)
       { p=new Node;
         p->gtri=X;
         p->tiep=q->tiep;
         q->tiep =p;
	   }
}
//---------------------------------------------- 
void chentruoc(Node *&dau, int X, int Y)
{ Node *t; // chua d/c nut dung truoc nut Y
  Node *q; // Chua d/c nut Y
  Node *p; // chua d/c nut X
  
  t=NULL;
  q= dau;
   while ((q!=NULL)&&(q->gtri!=Y))
    {t=q;
     q= q->tiep;
	}
	if (q!=NULL)
	  { if (q==dau)
	      chendau(dau,X);
	    else
		{ p=new Node;
		  p->gtri=X;
		  t->tiep=p;
		  p->tiep=q;
		  }  
	  }
}
//----------------------------------------------
void xoadau(Node *&dau)
{Node *p;
  if (dau!=NULL)
    {p=dau;
     dau=dau->tiep;
     delete p;
	}
}
//----------------------------------------------
void xoacuoi(Node *&dau)
{ Node *t,*p;
   if (dau!=NULL)
    { // Tim nut cuoi
       t=NULL;
       p=dau;
       while ((p!=NULL)&&(p->tiep!=NULL))
       { t=p;
         p=p->tiep;
	   }
	   if (p==dau)
	     xoadau(dau);
	   else
	    { t->tiep=NULL;
	      delete p;
		  }  
	}
}
//----------------------------------------------
void xoasau(Node *&dau, int X)
{ Node *p,*q;
   if (dau!=NULL)
   { //tim nut mang gia tri X
       p=dau;
       while ((p!=NULL)&&(p->gtri!=X))
         p=p->tiep;
         if (p!=NULL)
         { if (p==dau) xoadau(dau);
           else
           if (p->tiep!=NULL)
            {q=p->tiep;
             p->tiep=q->tiep;
             delete q;
			}
		 }
   }
}
//----------------------------------------------
void xoa(Node *&dau, int X)
{
  Node *q, *p;
  q=NULL;
  if (dau!=NULL)
  {
    // tim nut mang gia tri X
    p=dau;
    while (p!=NULL && p->gtri!=X)
    {
      q=p;p=p->tiep;
    }
    if (p!=NULL) // co nut mang gia tri X
      if(p==dau) xoadau(dau);
        else
        {
          q->tiep=p->tiep;
          delete p;
        }
  }
}
//----------------------------------------------
void xoatruoc(Node *&dau, int X)
{
  Node *q, *p, *t;
    t=NULL; q=NULL; p=NULL;
    if (dau!=NULL)
      {
        // tim nut mang gia tri X
        p=dau;
        while (p!=NULL && p->gtri!=X)
        { t=q;q=p;
          p=p->tiep;
        }
      if (p!=NULL)
        if(q!=dau)
          {if (dau->tiep==p) // nut X la nut thu 2
                xoadau(dau);
            else
            { t->tiep=p;
              delete q;
            }
          }    
        
      }

}
//----------------------------------------------
void sapxep(Node *&dau)
{
  int tam;
  Node *p, *q;
  p=dau;
    while (p!=NULL && p->tiep!=NULL)
    {
      q=p->tiep;
        while (q!=NULL)
        {if(p->gtri>q->gtri)
        { tam=p->gtri;
          p->gtri=q->gtri;
          q->gtri=tam;
        }
        q=q->tiep;
        }
      p=p->tiep;
    }
    
}
//----------------------------------------------
void daonguoctds(Node *dau, Node *&daumoi)
{ Node *p,*q;
      daumoi=NULL;
      p=dau;
      while (p!=NULL)
      {
        //xu ly
        q=new Node;
        q->gtri=p->gtri;
        q->tiep=daumoi;
        daumoi=q;
      p=p->tiep;
      }     
}
//----------------------------------------------
void daonguocktds(Node *&dau)
{ Node *p, *q;
      q=NULL;
        while (dau!=NULL)
        { p=dau;dau=dau->tiep;
          p->tiep=q;
          q=p;
        }
        dau=p;   
}
//----------------------------------------------
int main() 
{ khoitao(dau);
  nhapds(dau);
  duyetlap(dau);
  //chendau(dau,111);
  //chencuoi(dau,999);
  //chensau(dau,44,5);
  //chentruoc(dau,777,8);
  //xoadau(dau);
  //xoacuoi(dau);
  //xoa(dau, 5);
  //xoasau(dau,5);
  //xoatruoc(dau,5);
  //sapxep(dau);
  //daonguoctds(dau,daumoi);
  daonguocktds(dau);
  duyetlap(daumoi);
  /*printf("\n Duyet De qui \n");
  duyetdq(dau);
  printf("\n Tong cac nut %3d",tonglap(dau));
  printf("\n Tong cac nut %3d",tongdq(dau));
  printf("\n Tong cac nut %3d",tonglel(dau));
   printf("\n Tong cac nut %3d",tongledq(dau));*/
  return 0;
}