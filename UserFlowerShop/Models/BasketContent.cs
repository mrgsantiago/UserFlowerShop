//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserFlowerShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BasketContent
    {
        public int ID { get; set; }
        public int IDBasket { get; set; }
        public int IDGoods { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual Basket Basket { get; set; }
        public virtual Goods Goods { get; set; }
    }
}
