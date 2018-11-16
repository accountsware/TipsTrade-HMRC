﻿using Newtonsoft.Json;

namespace TipsTrade.HMRC.Api.CreateTestUser.Model {
  /// <summary>Represents a response containing a created organisation.</summary>
  public class OrganisationResult {
    /// <summary>Government Gateway ID.</summary>
    [JsonProperty("userId")]
    public string UserId { get; set; }

    /// <summary>Government Gateway password.</summary>
    [JsonProperty("password")]
    public string Password { get; set; }

    /// <summary>Government Gateway user's full name.</summary>
    [JsonProperty("userFullName")]
    public string FullName { get; set; }

    /// <summary>Government Gateway user's email address.</summary>
    [JsonProperty("emailAddress")]
    public string Email { get; set; }

    /// <summary>Organisation deatils.</summary>
    [JsonProperty("organisationDetails")]
    public Organisation OrganisationDetails { get; set; }

    /// <summary>Self Assessment UTR.</summary>
    [JsonProperty("saUtr")]
    public string SelfAssessmentUtr { get; set; }

    /// <summary>National Insurance number</summary>
    [JsonProperty("nino")]
    public string NiNumber { get; set; }

    /// <summary>Employer Reference.</summary>
    [JsonProperty("empRef")]
    public string EmployerReference { get; set; }

    /// <summary>Corporation Tax UTR.</summary>
    [JsonProperty("ctUtr")]
    public string CorporationTaxUtr { get; set; }

    /// <summary>VAT Reference Number</summary>
    [JsonProperty("vrn")]
    public string Vrn { get; set; }

    /// <summary>Making Tax Digital Income Tax ID</summary>
    [JsonProperty("mtdItId")]
    public string MtdIncomeTaxId { get; set; }

    /// <summary>LISA Manager Reference Number, in either 4-digit format (Znnnn) or 6-digit format (Znnnnnn).</summary>
    [JsonProperty("lisaManagerReferenceNumber")]
    public string LisaManagerReferenceNumber { get; set; }

    /// <summary>Secure Electronic Transfer reference number.</summary>
    [JsonProperty("secureElectronicTransferReferenceNumber")]
    public string SecureElectronicTransferReferenceNumber { get; set; }

    /// <summary>Pension Scheme Administrator Identifier.</summary>
    [JsonProperty("pensionSchemeAdministratorIdentifier")]
    public string PensionSchemeAdministratorIdentifier { get; set; }

    /// <summary>Economic Operator Registration and Identification (EORI) number.</summary>
    [JsonProperty("eoriNumber")]
    public string EoriNumber { get; set; }

    /// <summary>Represents an organisation.</summary>
    public class Organisation {
      /// <summary>Organisation name</summary>
      [JsonProperty("name")]
      public string Name { get; set; }

      /// <summary>Organisation address.</summary>
      [JsonProperty("address")]
      public Address Address { get; set; }
    }

    /// <summary>Represents an address.</summary>
    public class Address {
      /// <summary>Organisation's first line of address.</summary>
      [JsonProperty("line1")]
      public string Line1 { get; set; }

      /// <summary>Organisation's second line of address.</summary>
      [JsonProperty("line2")]
      public string Line2 { get; set; }

      /// <summary>Organisation's postcode.</summary>
      [JsonProperty("postcode")]
      public string Postcode { get; set; }
    }
  }
}