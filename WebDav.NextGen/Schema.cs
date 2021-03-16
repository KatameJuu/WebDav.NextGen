// ReSharper disable PartialTypeWithSinglePart
namespace WebDav.NextGen.Schema
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class ActiveLock {
                                                        
        public LockScope LockScope { get; set; }
        
        public LockType LockType { get; set; }
        
        public string Depth { get; set; }
        
        public System.Xml.XmlNode Owner { get; set; }
        
        public string Timeout { get; set; }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("href", IsNullable=false)]
        public string[] LockToken { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class LockScope {
                
        [System.Xml.Serialization.XmlElementAttribute("exclusive", typeof(Exclusive))]
        [System.Xml.Serialization.XmlElementAttribute("shared", typeof(Shared))]
        public object Item { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Exclusive {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Shared {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class LockType {
                
        public Write Write { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Write {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class LockEntry {
                        
        public LockScope LockScope { get; set; }
        
        public LockType LockType { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class LockInfo {
                                
        public LockScope LockScope { get; set; }
        
        public LockType LockType { get; set; }
        
        public System.Xml.XmlNode Owner { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class LockToken {
                
        [System.Xml.Serialization.XmlElementAttribute("href")]
        public string[] Href { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Link {
                        
        [System.Xml.Serialization.XmlElementAttribute("src")]
        public string[] Src { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dst")]
        public string[] Dst { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class MultiStatus {
                                
        [System.Xml.Serialization.XmlElementAttribute("response")]
        public Response[] Response { get; set; }
        
        public string ResponseDescription { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("sync-token", DataType="anyURI")]
        public string SyncToken { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Response {
                                                
        [System.Xml.Serialization.XmlElementAttribute("href")]
        public string[] Href { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("propstat", typeof(PropStat))]
        [System.Xml.Serialization.XmlElementAttribute("status", typeof(string))]
        public object[] Items { get; set; }
        
        public System.Xml.XmlElement Error { get; set; }
        
        public string ResponseDescription { get; set; }
        
        public Location Location { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class PropStat {
                                        
        public Prop Prop { get; set; }
        
        public string Status { get; set; }
        
        public System.Xml.XmlElement Error { get; set; }
        
        public string ResponseDescription { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Prop {
                                                                                                                
        public CreationDate CreationDate { get; set; }
        
        public DisplayName DisplayName { get; set; }
        
        public GetContentLanguage GetContentLanguage { get; set; }
        
        public GetContentLength GetContentLength { get; set; }
        
        public GetContentType GetContentType { get; set; }
        
        public GetETag GetETag { get; set; }
        
        public GetLastModified GetLastModified { get; set; }
        
        public LockDiscovery LockDiscovery { get; set; }
        
        public ResourceType ResourceType { get; set; }
        
        public SupportedLock SupportedLock { get; set; }
        
        [System.Xml.Serialization.XmlArrayAttribute("supported-report-set")]
        [System.Xml.Serialization.XmlArrayItemAttribute("supported-report", IsNullable=false)]
        public SupportedReport[] SupportedReportSet { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("quota-available-bytes")]
        public QuotaAvailableBytes QuotaAvailableBytes { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("quota-used-bytes")]
        public QuotaUsedBytes QuotaUsedBytes { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class CreationDate {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class DisplayName {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class GetContentLanguage {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class GetContentLength {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class GetContentType {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class GetETag {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class GetLastModified {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class LockDiscovery {
                
        [System.Xml.Serialization.XmlElementAttribute("activelock")]
        public ActiveLock[] ActiveLock { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class ResourceType {
                        
        public Collection Collection { get; set; }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Collection {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class SupportedLock {
                
        [System.Xml.Serialization.XmlElementAttribute("lockentry")]
        public LockEntry[] LockEntry { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("supported-report", Namespace="DAV:", IsNullable=false)]
    public partial class SupportedReport {
                
        public System.Xml.XmlElement Report { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("quota-available-bytes", Namespace="DAV:", IsNullable=false)]
    public partial class QuotaAvailableBytes {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("quota-used-bytes", Namespace="DAV:", IsNullable=false)]
    public partial class QuotaUsedBytes {
                
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Location {
                
        public string Href { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class PropertyBehavior {
                
        [System.Xml.Serialization.XmlElementAttribute("keepalive", typeof(KeepAlive))]
        [System.Xml.Serialization.XmlElementAttribute("omit", typeof(Omit))]
        public object Item { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class KeepAlive {
                        
        [System.Xml.Serialization.XmlElementAttribute("href")]
        public string[] Href { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Omit {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class PropertyUpdate {
                
        [System.Xml.Serialization.XmlElementAttribute("remove", typeof(Remove))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(Set))]
        public object[] Items { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Remove {
                
        public Prop Prop { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Set {
                
        public Prop Prop { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class PropFind {
                
        [System.Xml.Serialization.XmlElementAttribute("allprop", typeof(AllProp))]
        [System.Xml.Serialization.XmlElementAttribute("prop", typeof(Prop))]
        [System.Xml.Serialization.XmlElementAttribute("propname", typeof(PropName))]
        public object Item { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class AllProp {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class PropName {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Source {
                
        [System.Xml.Serialization.XmlElementAttribute("link")]
        public Link[] Link { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("supported-report-set", Namespace="DAV:", IsNullable=false)]
    public partial class SupportedReportSet {
                
        [System.Xml.Serialization.XmlElementAttribute("supported-report")]
        public SupportedReport[] SupportedReport { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("sync-collection", Namespace="DAV:", IsNullable=false)]
    public partial class SyncCollection {
                                        
        [System.Xml.Serialization.XmlElementAttribute("sync-token", DataType="anyURI")]
        public string SyncToken { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("sync-level")]
        public SyncLevel SyncLevel { get; set; }
        
        public Limit Limit { get; set; }
        
        public Prop Prop { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("sync-level", Namespace="DAV:", IsNullable=false)]
    public enum SyncLevel {
        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Level1,
        
        Infinite,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class Limit {
                
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string NResults { get; set; }
    }
}