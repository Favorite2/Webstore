//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Furniture_store
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSet
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdAgent { get; set; }
        public int IdProduct { get; set; }
        public int IdProvider { get; set; }
        public long Available { get; set; }
        public long Remaining { get; set; }
    
        public virtual AgentsSet AgentsSet { get; set; }
        public virtual ClientsSet ClientsSet { get; set; }
        public virtual Provider Provider { get; set; }
    }
}