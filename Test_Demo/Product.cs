//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCategory { get; set; }
        public byte[] ProductPhoto { get; set; }
        public string ProductManufacturer { get; set; }
        public decimal ProductCost { get; set; }
        public Nullable<byte> ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductStatus { get; set; }
        public string ProductUnit { get; set; }
        public Nullable<byte> ProductMaxDiscoun { get; set; }
        public string ProductProvider { get; set; }

        public string ImgPath
        {
            get
            {
                return "/Resources/" + this.ProductArticleNumber + ".jpg";
            }
        }
    
        public virtual CategoryProduct CategoryProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
