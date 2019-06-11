// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A WebLinkedService that uses client certificate based authentication to
    /// communicate with an HTTP endpoint. This scheme follows mutual
    /// authentication; the server must also provide valid credentials to the
    /// client.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ClientCertificate")]
    public partial class WebClientCertificateAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WebClientCertificateAuthentication class.
        /// </summary>
        public WebClientCertificateAuthentication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WebClientCertificateAuthentication class.
        /// </summary>
        /// <param name="url">The URL of the web service endpoint, e.g.
        /// http://www.microsoft.com . Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="pfx">Base64-encoded contents of a PFX file.</param>
        /// <param name="password">Password for the PFX file.</param>
        public WebClientCertificateAuthentication(object url, SecretBase pfx, SecretBase password)
            : base(url)
        {
            Pfx = pfx;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base64-encoded contents of a PFX file.
        /// </summary>
        [JsonProperty(PropertyName = "pfx")]
        public SecretBase Pfx { get; set; }

        /// <summary>
        /// Gets or sets password for the PFX file.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Pfx == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Pfx");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}