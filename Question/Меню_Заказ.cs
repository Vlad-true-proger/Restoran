//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Question
{
    using System;
    using System.Collections.Generic;
    
    public partial class Меню_Заказ
    {
        public int id_блюда { get; set; }
        public string id_заказа { get; set; }
        public string Количество_блюд { get; set; }
    
        public virtual Заказ Заказ { get; set; }
        public virtual Меню Меню { get; set; }
    }
}
