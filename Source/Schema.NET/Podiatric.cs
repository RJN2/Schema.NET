namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Podiatry is the care of the human foot, especially the diagnosis and treatment of foot disorders.
    /// </summary>
    [DataContract]
    public class Podiatric : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Podiatric";
    }
}