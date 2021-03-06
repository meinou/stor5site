﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articule
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.Goods = new HashSet<Good>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Good> Goods { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Nullable<int> orderID { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class forComptable
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> goodID { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Good
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Good()
        {
            this.OrdersGoods = new HashSet<OrdersGood>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> categoryID { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersGood> OrdersGoods { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Customers = new HashSet<Customer>();
            this.OrdersGoods = new HashSet<OrdersGood>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> goodOrderId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersGood> OrdersGoods { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersGood
    {
        public int id { get; set; }
        public Nullable<int> orderID { get; set; }
        public Nullable<int> goodID { get; set; }
    
        public virtual Good Good { get; set; }
        public virtual Order Order { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class sysdiagram
    {
        public string name { get; set; }
        public int principal_id { get; set; }
        public int diagram_id { get; set; }
        public Nullable<int> version { get; set; }
        public byte[] definition { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    using System.Collections.Generic;
    
    public partial class taxCalculation
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> goodID { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    
    public partial class showLuxury_Result
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> categoryID { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    
    public partial class sp_helpdiagramdefinition_Result
    {
        public Nullable<int> version { get; set; }
        public byte[] definition { get; set; }
    }
}
namespace BLL.Stor
{
    using System;
    
    public partial class sp_helpdiagrams_Result
    {
        public string Database { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Owner { get; set; }
        public int OwnerID { get; set; }
    }
}
