using System;
using System.Collections.Generic;
using System.Text;

namespace Core.API
{

    public class DatabaseQuery
    {
        /// <summary>
        /// The source of data
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Fields which are will be processed
        /// </summary>
        public IList<string> Fields { get; set; }

        /// <summary>
        /// Sorting settings
        /// </summary>
        public SortConfig SortConfig { get; set; }

        /// <summary
        /// The number of processing entries from the beginning
        /// </summary>
        public int? Top { get; set; }

        /// <summary
        /// The number of skipped entries from the beginning
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// Query to database
        /// </summary>
        public Querybase Query { get; set; }
    }

    public class Querybase
    {
        public Querybase()
        {
            QueryType = QueryType.Unexpected;
        }

        public QueryType QueryType { get; protected set; }
    }

    public class QueryLeaf : Querybase
    {
        public QueryLeaf()
        {
            base.QueryType = QueryType.Leaf;
            FilterOperator = FilterOperator.Unexpected;
        }

        public IList<string> Fields { get; set; }

        public object Value { get; set; }

        public FilterOperator FilterOperator { get; set; }
    }

    public class SortConfig
    {
        public SortDirection SortDirection { get; set; }
    }

    public class QueryTree : Querybase
    {
        public QueryTree()
        {
            base.QueryType = QueryType.Tree;
            GroupOperator = GroupOperator.And; // and by default
            Childrens = new List<Querybase>();
        }

        public IList<Querybase> Childrens { get; set; }

        public GroupOperator GroupOperator { get; set; }
    }

    public enum SortDirection
    {
        Asc,
        Desc,
    }

    public enum QueryType
    {
        Unexpected,

        Leaf,
        Tree
    }

    public enum FilterOperator
    {
        Unexpected,

        Not,
        Equal,
        NotEqual,
        GreaterThan,
        GreaterThanOrEqual,
        LessThan,
        LessThanOrEqual,
        StartsWith,
        EndsWith,
        Contains,
    }

    public enum GroupOperator
    {
        Unexpected,

        Or,
        And,
    }
}
