using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Success            = "Islem Basarili.";
        public static string Error              = "Islem Basarisiz!";
        public static string ProductAdded       = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime    = "Sistem bakımda.";
        public static string ProductsListed     = "Ürünler listelendi.";
        public static string ProductDeleted     = "Ürünler silindi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olmalıdır.";
        public static string ProductNameAllreadyExists ="Aynı isimde ürün ekleyemezsiniz.";
        public static string CategoryLimitExceded ="Kategori Limiti Aşıldı!";
    }
}
