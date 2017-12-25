//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeuClass.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class LessonContent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LessonContent()
        {
            this.LessonComments = new HashSet<LessonComment>();
            this.LessonContentLikes = new HashSet<LessonContentLike>();
            this.Reports = new HashSet<Report>();
        }
    
        public int LessonContentID { get; set; }
        public Nullable<int> AddedUserID { get; set; }
        public string LessonContentTitle { get; set; }
        public string LessonContentText { get; set; }
        public Nullable<int> LessonContentFileID { get; set; }
        public Nullable<int> LessonID { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonComment> LessonComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonContentLike> LessonContentLikes { get; set; }
        public virtual User User { get; set; }
        public virtual UserFile UserFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }
    }
}
