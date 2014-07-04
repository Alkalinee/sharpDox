namespace SharpDox.Model.Documentation.Token
{
    /// <default>
    ///     <summary>
    ///     All roles for the documentation tokens.
    ///     </summary>
    /// </default>
    /// <de>
    ///     <summary>
    ///     Alle Rollen die ein Element in einer Dokumentation annehmen kann.
    ///     </summary>
    /// </de>
    public static class SDTokenRole
    {
        /// <default>
        ///     <summary>
        ///     Represents a code node.
        ///     </summary>
        /// </default>
        /// <de>
        ///     <summary>
        ///     Repr�sentiert einen Code-Element.
        ///     </summary>
        /// </de>
	    public const string Code = "Code";

        /// <default>
        ///     <summary>
        ///     Represents a paragraph.
        ///     </summary>
        /// </default>
        /// <de>
        ///     <summary>
        ///     Repr�sentiert einen Absatz.
        ///     </summary>
        /// </de>
        public const string Paragraph = "Paragraph";

        /// <default>
        ///     <summary>
        ///     Represents a type parameter reference.
        ///     </summary>
        /// </default>
        /// <de>
        ///     <summary>
        ///     Repr�sentiert eine Typparameterreferenz.
        ///     </summary>
        /// </de>
        public const string TypeParamRef = "TypeParamRef";

        /// <default>
        ///     <summary>
        ///     Represents a parameter reference.
        ///     </summary>
        /// </default>
        /// <de>
        ///     <summary>
        ///     Repr�sentiert eine Parameterreferenz.
        ///     </summary>
        /// </de>
        public const string ParamRef = "ParamRef";

        /// <default>
        ///     <summary>
        ///     Represents a  reference.
        ///     </summary>
        /// </default>
        /// <de>
        ///     <summary>
        ///     Repr�sentiert eine Referenz.
        ///     </summary>
        /// </de>
        public const string See = "See";

        /// <default>
        ///     <summary>
        ///     Represents plain text.
        ///     </summary>
        /// </default>
        /// <de>
        ///     <summary>
        ///     Repr�sentiert einfachen Text.
        ///     </summary>
        /// </de>
        public const string Text = "Text";
    }
}