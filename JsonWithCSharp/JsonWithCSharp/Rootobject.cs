using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonWithCSharp
{

    public class Rootobject
    {
        public Meta meta { get; set; }
        public object[][] data { get; set; }
    }

    public class Meta
    {
        public View view { get; set; }
    }

    public class View
    {
        public string id { get; set; }
        public string name { get; set; }
        public string attribution { get; set; }
        public string attributionLink { get; set; }
        public int averageRating { get; set; }
        public string category { get; set; }
        public int createdAt { get; set; }
        public string description { get; set; }
        public string displayType { get; set; }
        public int downloadCount { get; set; }
        public bool hideFromCatalog { get; set; }
        public bool hideFromDataJson { get; set; }
        public string iconUrl { get; set; }
        public int indexUpdatedAt { get; set; }
        public bool newBackend { get; set; }
        public int numberOfComments { get; set; }
        public int oid { get; set; }
        public string provenance { get; set; }
        public bool publicationAppendEnabled { get; set; }
        public int publicationDate { get; set; }
        public int publicationGroup { get; set; }
        public string publicationStage { get; set; }
        public string rowClass { get; set; }
        public int rowsUpdatedAt { get; set; }
        public string rowsUpdatedBy { get; set; }
        public int tableId { get; set; }
        public int totalTimesRated { get; set; }
        public int viewCount { get; set; }
        public int viewLastModified { get; set; }
        public string viewType { get; set; }
        public Column[] columns { get; set; }
        public Grant[] grants { get; set; }
        public Metadata metadata { get; set; }
        public Owner owner { get; set; }
        public Query query { get; set; }
        public string[] rights { get; set; }
        public Tableauthor tableAuthor { get; set; }
        public string[] tags { get; set; }
        public string[] flags { get; set; }
    }

    public class Metadata
    {
        public Jsonquery jsonQuery { get; set; }
        public string rdfClass { get; set; }
        public string rdfSubject { get; set; }
        public Custom_Fields custom_fields { get; set; }
        public string rowIdentifier { get; set; }
        public string rowLabel { get; set; }
        public string[] availableDisplayTypes { get; set; }
        public Rendertypeconfig renderTypeConfig { get; set; }
    }

    public class Jsonquery
    {
        public Order[] order { get; set; }
    }

    public class Order
    {
        public string columnFieldName { get; set; }
        public bool ascending { get; set; }
    }

    public class Custom_Fields
    {
        public CommonCore CommonCore { get; set; }
        public DatasetInformation DatasetInformation { get; set; }
    }

    public class CommonCore
    {
        public string ContactEmail { get; set; }
        public string ContactName { get; set; }
        public string ProgramCode { get; set; }
        public string BureauCode { get; set; }
    }

    public class DatasetInformation
    {
        public string GlossaryMethodology { get; set; }
    }

    public class Rendertypeconfig
    {
        public Visible visible { get; set; }
    }

    public class Visible
    {
        public bool table { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string roleName { get; set; }
        public string screenName { get; set; }
        public string[] rights { get; set; }
    }

    public class Query
    {
        public Orderby[] orderBys { get; set; }
    }

    public class Orderby
    {
        public bool ascending { get; set; }
        public Expression expression { get; set; }
    }

    public class Expression
    {
        public int columnId { get; set; }
        public string type { get; set; }
    }

    public class Tableauthor
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string roleName { get; set; }
        public string screenName { get; set; }
        public string[] rights { get; set; }
    }

    public class Column
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dataTypeName { get; set; }
        public string fieldName { get; set; }
        public int position { get; set; }
        public string renderTypeName { get; set; }
        public Format format { get; set; }
        public string[] flags { get; set; }
        public string description { get; set; }
        public int tableColumnId { get; set; }
        public int width { get; set; }
        public Cachedcontents cachedContents { get; set; }
        public string[] subColumnTypes { get; set; }
    }

    public class Format
    {
        public string precisionStyle { get; set; }
        public string noCommas { get; set; }
        public string align { get; set; }
        public string displayStyle { get; set; }
    }

    public class Cachedcontents
    {
        public object largest { get; set; }
        public int non_null { get; set; }
        public string average { get; set; }
        public int _null { get; set; }
        public Top[] top { get; set; }
        public object smallest { get; set; }
        public string sum { get; set; }
    }

    public class Top
    {
        public object item { get; set; }
        public int count { get; set; }
    }

    public class Grant
    {
        public bool inherited { get; set; }
        public string type { get; set; }
        public string[] flags { get; set; }
    }

}
