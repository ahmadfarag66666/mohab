using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MrMohb.PL
{
    class CLsMain
    {
        //Insert New EMB    اول حاجة عملتها
        public void insertwhithoutImage(int @ID, string EMP_Name,string EMP_State,DateTime Date_State,double Amount,string EMP_Code,string Receipt,string Note )
        {
            DXL ob = new DXL();
            ob.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@ID", SqlDbType.Int);
            p[0].Value = ID;
            p[1] = new SqlParameter("@EMP_Name", SqlDbType.NVarChar, 50);
            p[1].Value = EMP_Name;
            p[2] = new SqlParameter("@EMP_State", SqlDbType.NVarChar, 50);
            p[2].Value = EMP_State;
            p[3] = new SqlParameter("@Date_State", SqlDbType.DateTime);
            p[3].Value = Date_State;
            p[4] = new SqlParameter("@Amount", SqlDbType.Decimal);
            p[4].Value = Amount;
            p[5] = new SqlParameter("@EMP_Code", SqlDbType.NVarChar, 50);
            p[5].Value = @EMP_Code;
            p[6] = new SqlParameter("@Receipt", SqlDbType.NVarChar, 50);
            p[6].Value = Receipt;
            p[7] = new SqlParameter("@Note ", SqlDbType.NVarChar, 50);
            p[7].Value = Note ;

            ob.RUA("InsertWhithoutImage", p);
            ob.close();//18 nezar  and  15 salem

        }

        public DataTable maxid()//      ثاني حاجة عملتها
        {
            DataTable dt = new DataTable();
            DXL ob = new DXL();
            ob.open();
            dt = ob.Reader("MaxID", null);
            ob.close();
            return dt;

        }

        public DataTable displyEmpOn_dgv()//      
        {
            DataTable dt = new DataTable();
            DXL ob = new DXL();
            ob.open();
            dt = ob.Reader("displyEmpOn_dgv", null);
            ob.close();
            return dt;

        }





























































        public DataTable loadV_productitem()// ok1 
        {

            DataTable dt = new DataTable();//6
            MrMohb.DXL ob = new MrMohb.DXL();
            ob.open();
            dt = ob.Reader("LoadV_ProductItemSP", null);
            ob.close();
            return dt;//6

        }
























        public DataTable max_product_id_sp()//   و13سالم   15 نزار جلب اعلى رقم  للمنتجات
        {
            DataTable dt = new DataTable();
            DXL ob = new DXL();
            ob.open();
            dt = ob.Reader("Max_Product_ID_SP", null);
            ob.close();
            return dt;//15
        }


        //  درس15سالم اولا اضافة المنتج بدون صورة
        

        //  درس17سالم ثانيا اضافة المنتج بصورة و18نزار
        public void insert_productswithimg(int pro_ID, string pro_code, string pro_name, double pro_priceBuy, double pro_priceSale  //18  nezar  and 15 salem
                              , double pro_priceEarn, double pro_qty, byte[] pro_IMG, int pro_iditem)
        {
            DXL ob = new DXL();
            ob.open();
            SqlParameter[] p = new SqlParameter[9];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = pro_ID;
            p[1] = new SqlParameter("@code", SqlDbType.NVarChar, 50);
            p[1].Value = pro_code;
            p[2] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[2].Value = pro_name;
            p[3] = new SqlParameter("@price_buy", SqlDbType.Decimal);
            p[3].Value = pro_priceBuy;
            p[4] = new SqlParameter("@price_sale", SqlDbType.Decimal);
            p[4].Value = pro_priceSale;
            p[5] = new SqlParameter("@price_Earn", SqlDbType.Decimal);
            p[5].Value = pro_priceEarn;
            p[6] = new SqlParameter("@qty", SqlDbType.Decimal);
            p[6].Value = pro_qty;
            p[7] = new SqlParameter("@img_Product", SqlDbType.Image);
            p[7].Value = pro_IMG;
            p[8] = new SqlParameter("@idItem", SqlDbType.Int);
            p[8].Value = pro_iditem;

            ob.RUA("Insert_ProductsWithIMG", p);
            ob.close();//18 nezar  and  17 salem

        }

        //اولا تعديل المنتجات بدون صوره درس سالم20
        public void update_productwithoutimg(string code_PRO, string NAME_PRO, double price_buy, double price_sale
                                             , double price_Earn, double qty, int idItem)       //  20 سالم
        {
            DXL ob = new DXL();
            ob.open();
            SqlParameter[] p = new SqlParameter[7];
            p[0] = new SqlParameter("@code", SqlDbType.NVarChar, 50);
            p[0].Value = code_PRO;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = NAME_PRO;
            p[2] = new SqlParameter("@price_buy", SqlDbType.Decimal);
            p[2].Value = price_buy;
            p[3] = new SqlParameter("@price_sale", SqlDbType.Decimal);
            p[3].Value = price_sale;
            p[4] = new SqlParameter("@price_Earn", SqlDbType.Decimal);
            p[4].Value = price_Earn;
            p[5] = new SqlParameter("@qty", SqlDbType.Decimal);
            p[5].Value = qty;
            p[6] = new SqlParameter("@idItem", SqlDbType.Int);
            p[6].Value = idItem;



            ob.RUA("Update_ProductWithoutIMG ", p);
            ob.close();


        }

        //اولا تعديل المنتجات ب صوره درس سالم20
        public void update_productwithimg(string code_PRO, string NAME_PRO, double price_buy, double price_sale
                                             , double price_Earn, double qty, byte[] img, int idItem)       //  20 سالم
        {
            DXL ob = new DXL();
            ob.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@code", SqlDbType.NVarChar, 50);
            p[0].Value = code_PRO;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = NAME_PRO;
            p[2] = new SqlParameter("@price_buy", SqlDbType.Decimal);
            p[2].Value = price_buy;
            p[3] = new SqlParameter("@price_sale", SqlDbType.Decimal);
            p[3].Value = price_sale;
            p[4] = new SqlParameter("@price_Earn", SqlDbType.Decimal);
            p[4].Value = price_Earn;
            p[5] = new SqlParameter("@qty", SqlDbType.Decimal);
            p[5].Value = qty;
            p[6] = new SqlParameter("@img_Product", SqlDbType.Image);
            p[6].Value = img;
            p[7] = new SqlParameter("@idItem", SqlDbType.Int);
            p[7].Value = idItem;



            ob.RUA("Update_ProductWithIMG", p);
            ob.close();


        }



        #region عرض صورة المنتج على الفورمه لعمل تعديل على الفورمه درس27 ودرس19 سالم
        public DataTable getimage_prouduct(string CODE_PRO)    //  درس 27عرض صورة المريض
        {
            DataTable dt = new DataTable();
            DXL ob = new DXL();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@code", SqlDbType.NVarChar, 50);
            p[0].Value = CODE_PRO;
            dt = ob.Reader("GetImage_ProuductSP", p);
            ob.close();
            return dt;
        }
        #endregion





        //حذف صنف محاضره 10سالم
        public void delete_item_sp(int Item_ID)//  void لانه هيخزن قيمه فى الداتا بيز ومش هيرجع قيمه
        {
            DXL ob = new DXL();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            p[0].Value = Item_ID;
            ob.RUA("Delete_Item_SP", p);
            ob.close();//33
        }

        //درس 35  سالم عرض المنتجات فى شاشى المبيعات
        //public void SelectProductByCode(string Code)
        //{
        //    DataTable dt = new DataTable();
        //    DXL ob = new DXL();
        //    ob.open();
        //    SqlParameter[] p = new SqlParameter[1];
        //    p[0] = new SqlParameter("@code", SqlDbType.NVarChar, 50);
        //    p[0].Value = Code;
        //    dt = ob.Reader("SelectProductByCode", p);
        //    if (dt.Rows.Count > 0)
        //    {
        //        NAME = dt.Rows[0][2].ToString();
        //        BRICE_SALE = Convert.ToDouble(dt.Rows[0][4]);
        //    }
        //    else
        //    {
        //        NAME = "";
        //        BRICE_SALE = 0;
        //    }
        //    ob.close();//  34 salem
        //    //      

        //}

        ////درس40سالم البحث عن المنتجات//////////////////////////////////////////////////////////////
        //public DataTable Search_ProductSale(string txt)
        //{
        //    DataTable dt = new DataTable();
        //    DXL ob = new DXL();
        //    ob.open();
        //    SqlParameter[] p = new SqlParameter[1];
        //    p[0] = new SqlParameter("@txt", SqlDbType.NVarChar, 50);
        //    p[0].Value = txt;
        //    dt = ob.Reader("Search_ProductSaleSP", p);
        //    ob.close();
        //    return dt;//  40   salem
        //}

    }



}

