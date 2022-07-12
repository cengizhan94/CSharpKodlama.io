using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied = "Yetkisiz İşlem.";
        public static string UserRegistered      = "Kayıt Başarılı.";
        public static string UserNotFound        ="Kullanıcı Bulunamadı.";
        public static string PasswordError       = "Parola Hatalı.";
        public static string SuccessfulLogin     ="Giriş Başarılı";
        public static string UserAlreadyExists   ="Kullanıcı Mevcuttur.";
        public static string AccessTokenCreated  ="Token Oluşturuldu";
    }
}
