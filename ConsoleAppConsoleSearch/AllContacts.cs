// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ConsoleAppConsoleSearch;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace ConsoleAppConsoleSearch
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("versionValue")]
        public long VersionValue { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("company.id")]
        public long CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender.id")]
        public long GenderId { get; set; }

        [JsonProperty("businessUnit.id")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("contactTypes")]
        public object[] ContactTypes { get; set; }

        [JsonProperty("accountingReference")]
        public string AccountingReference { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("languageMappings")]
        public LanguageMapping[] LanguageMappings { get; set; }

        [JsonProperty("primaryNumber")]
        public Number PrimaryNumber { get; set; }

        [JsonProperty("numbers")]
        public Number[] Numbers { get; set; }

        [JsonProperty("primaryAddress")]
        public Address PrimaryAddress { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("primaryEmail")]
        public Email PrimaryEmail { get; set; }

        [JsonProperty("emails")]
        public Email[] Emails { get; set; }

        [JsonProperty("hasTransportation")]
        public object HasTransportation { get; set; }

        [JsonProperty("hasChildren")]
        public object HasChildren { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("companyName")]
        public object CompanyName { get; set; }

        [JsonProperty("website")]
        public object Website { get; set; }

        [JsonProperty("region")]
        public object Region { get; set; }

        [JsonProperty("countryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [JsonProperty("countryOfResidence")]
        public string CountryOfResidence { get; set; }

        [JsonProperty("countryOfNationality")]
        public string CountryOfNationality { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("activeNote")]
        public string ActiveNote { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("experience")]
        public string Experience { get; set; }

        [JsonProperty("registeredTaxId")]
        public object RegisteredTaxId { get; set; }

        [JsonProperty("bankAccount")]
        public object BankAccount { get; set; }

        [JsonProperty("sortCode")]
        public object SortCode { get; set; }

        [JsonProperty("iban")]
        public object Iban { get; set; }

        [JsonProperty("swift")]
        public object Swift { get; set; }

        [JsonProperty("eft.id")]
        public string EftId { get; set; }

        [JsonProperty("eft.name")]
        public string EftName { get; set; }

        [JsonProperty("paymentMethod.id")]
        public string PaymentMethodId { get; set; }

        [JsonProperty("paymentMethod.name")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("registeredTax")]
        public bool RegisteredTax { get; set; }

        [JsonProperty("registeredTaxIdDescription")]
        public object RegisteredTaxIdDescription { get; set; }

        [JsonProperty("employmentCategory.id")]
        public long EmploymentCategoryId { get; set; }

        [JsonProperty("employmentCategory.description")]
        public string EmploymentCategoryDescription { get; set; }

        [JsonProperty("assignmentTier.id")]
        public long AssignmentTierId { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("document")]
        public object Document { get; set; }

        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }

        [JsonProperty("outOfOffice")]
        public bool OutOfOffice { get; set; }

        [JsonProperty("disableUpcomingReminder")]
        public object DisableUpcomingReminder { get; set; }

        [JsonProperty("disableCloseReminder")]
        public object DisableCloseReminder { get; set; }

        [JsonProperty("disableConfirmReminder")]
        public object DisableConfirmReminder { get; set; }

        [JsonProperty("bankAccountDescription")]
        public object BankAccountDescription { get; set; }

        [JsonProperty("timeWorked")]
        public string TimeWorked { get; set; }

        [JsonProperty("activationDate")]
        public object ActivationDate { get; set; }

        [JsonProperty("originalStartDate")]
        public object OriginalStartDate { get; set; }

        [JsonProperty("datePhotoSentToPrinter")]
        public object DatePhotoSentToPrinter { get; set; }

        [JsonProperty("datePhotoSentToInterpreter")]
        public object DatePhotoSentToInterpreter { get; set; }

        [JsonProperty("inductionDate")]
        public object InductionDate { get; set; }

        [JsonProperty("reActivationDate")]
        public object ReActivationDate { get; set; }

        [JsonProperty("iolNrcpdNumber")]
        public object IolNrcpdNumber { get; set; }

        [JsonProperty("referralSource")]
        public object ReferralSource { get; set; }

        [JsonProperty("refereeSourceName")]
        public object RefereeSourceName { get; set; }

        [JsonProperty("recruiterName")]
        public object RecruiterName { get; set; }

        [JsonProperty("taleoId")]
        public object TaleoId { get; set; }

        [JsonProperty("bankAccountReference")]
        public object BankAccountReference { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("rateSummary")]
        public RateSummary RateSummary { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("languagesId")]
        public long LanguagesId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }

        [JsonProperty("moreLanguages")]
        public string MoreLanguages { get; set; }

        [JsonProperty("employmentEligibilityStatus")]
        public string EmploymentEligibilityStatus { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("client.id")]
        public string ClientId { get; set; }

        [JsonProperty("clientLabel")]
        public object ClientLabel { get; set; }

        [JsonProperty("company.id")]
        public long CompanyId { get; set; }

        [JsonProperty("customer.id")]
        public string CustomerId { get; set; }

        [JsonProperty("customerBilling.id")]
        public string CustomerBillingId { get; set; }

        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("addrEntered")]
        public string AddrEntered { get; set; }

        [JsonProperty("addrFormatted")]
        public string AddrFormatted { get; set; }

        [JsonProperty("aptUnit")]
        public object AptUnit { get; set; }

        [JsonProperty("preamble")]
        public object Preamble { get; set; }

        [JsonProperty("street1")]
        public string Street1 { get; set; }

        [JsonProperty("street2")]
        public object Street2 { get; set; }

        [JsonProperty("street3")]
        public object Street3 { get; set; }

        [JsonProperty("cityTown")]
        public string CityTown { get; set; }

        [JsonProperty("stateCounty")]
        public string StateCounty { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("primaryAddress")]
        public bool PrimaryAddress { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("validationStatus")]
        public string ValidationStatus { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("addressPhone")]
        public object AddressPhone { get; set; }

        [JsonProperty("addressFax")]
        public object AddressFax { get; set; }

        [JsonProperty("addressEmail")]
        public object AddressEmail { get; set; }

        [JsonProperty("contactPerson")]
        public object ContactPerson { get; set; }

        [JsonProperty("costCenter")]
        public object CostCenter { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("parent.id")]
        public string ParentId { get; set; }

        [JsonProperty("parent.label")]
        public string ParentLabel { get; set; }

        [JsonProperty("publicNotes")]
        public object PublicNotes { get; set; }

        [JsonProperty("region.id")]
        public string RegionId { get; set; }

        [JsonProperty("billingRegion.id")]
        public string BillingRegionId { get; set; }

        [JsonProperty("costCenterName")]
        public object CostCenterName { get; set; }

        [JsonProperty("timeZone")]
        public object TimeZone { get; set; }
    }

    public partial class Email
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("addressVerified")]
        public object AddressVerified { get; set; }

        [JsonProperty("dateVerified")]
        public object DateVerified { get; set; }

        [JsonProperty("primaryEmail")]
        public bool PrimaryEmail { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }
    }

    public partial class LanguageMapping
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("contact.id")]
        public long ContactId { get; set; }

        [JsonProperty("language.id")]
        public long LanguageId { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }
    }

    public partial class Language
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alternates")]
        public string Alternates { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("iso639_3Tag")]
        public string Iso6393Tag { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alias")]
        public object Alias { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public partial class Number
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parsedNumber")]
        public string ParsedNumber { get; set; }

        [JsonProperty("numberFormatted")]
        public object NumberFormatted { get; set; }

        [JsonProperty("countryCode")]
        public object CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public object AreaCode { get; set; }

        [JsonProperty("number")]
        public object NumberNumber { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }

        [JsonProperty("primaryNumber")]
        public bool PrimaryNumber { get; set; }
    }

    public partial class RateSummary
    {
        [JsonProperty("inperson")]
        public string Inperson { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("defaultOption")]
        public bool DefaultOption { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("l10nKey")]
        public object L10NKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameKey")]
        public string NameKey { get; set; }
    }

    public partial class Welcome
    {
        public static Welcome[] FromJson(string json) => JsonConvert.DeserializeObject<Welcome[]>(json, ConsoleAppConsoleSearch.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome[] self) => JsonConvert.SerializeObject(self, ConsoleAppConsoleSearch.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

