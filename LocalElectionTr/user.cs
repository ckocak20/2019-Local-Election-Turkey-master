
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LocalElectionTr
{

using System;
    using System.Collections.Generic;
    
public partial class user
{

    public int userID { get; set; }

    public string user_fname { get; set; }

    public string user_lname { get; set; }

    public string user_gender { get; set; }

    public string user_password { get; set; }

    public Nullable<bool> isActive { get; set; }

    public Nullable<bool> isUsed { get; set; }

    public string user_tc { get; set; }

    public Nullable<int> user_il { get; set; }

    public Nullable<int> user_ilce { get; set; }



    public virtual ilceler ilceler { get; set; }

    public virtual iller iller { get; set; }

}

}
