// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A certificate that can be installed on compute nodes and can be used to authenticate operations on a node.
    /// </summary>
    public partial class Certificate : ITransportObjectProvider<Models.CertificateAddParameter>, IInheritedBehaviors, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<Common.CertificateFormat?> CertificateFormatProperty;
            public readonly PropertyAccessor<string> DataProperty;
            public readonly PropertyAccessor<DeleteCertificateError> DeleteCertificateErrorProperty;
            public readonly PropertyAccessor<string> PasswordProperty;
            public readonly PropertyAccessor<Common.CertificateState?> PreviousStateProperty;
            public readonly PropertyAccessor<DateTime?> PreviousStateTransitionTimeProperty;
            public readonly PropertyAccessor<string> PublicDataProperty;
            public readonly PropertyAccessor<Common.CertificateState?> StateProperty;
            public readonly PropertyAccessor<DateTime?> StateTransitionTimeProperty;
            public readonly PropertyAccessor<string> ThumbprintProperty;
            public readonly PropertyAccessor<string> ThumbprintAlgorithmProperty;
            public readonly PropertyAccessor<string> UrlProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.CertificateFormatProperty = this.CreatePropertyAccessor<Common.CertificateFormat?>(nameof(CertificateFormat), BindingAccess.Read | BindingAccess.Write);
                this.DataProperty = this.CreatePropertyAccessor<string>(nameof(Data), BindingAccess.Read | BindingAccess.Write);
                this.DeleteCertificateErrorProperty = this.CreatePropertyAccessor<DeleteCertificateError>(nameof(DeleteCertificateError), BindingAccess.None);
                this.PasswordProperty = this.CreatePropertyAccessor<string>(nameof(Password), BindingAccess.Read | BindingAccess.Write);
                this.PreviousStateProperty = this.CreatePropertyAccessor<Common.CertificateState?>(nameof(PreviousState), BindingAccess.None);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>(nameof(PreviousStateTransitionTime), BindingAccess.None);
                this.PublicDataProperty = this.CreatePropertyAccessor<string>(nameof(PublicData), BindingAccess.None);
                this.StateProperty = this.CreatePropertyAccessor<Common.CertificateState?>(nameof(State), BindingAccess.None);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>(nameof(StateTransitionTime), BindingAccess.None);
                this.ThumbprintProperty = this.CreatePropertyAccessor<string>(nameof(Thumbprint), BindingAccess.Read | BindingAccess.Write);
                this.ThumbprintAlgorithmProperty = this.CreatePropertyAccessor<string>(nameof(ThumbprintAlgorithm), BindingAccess.Read | BindingAccess.Write);
                this.UrlProperty = this.CreatePropertyAccessor<string>(nameof(Url), BindingAccess.None);
            }

            public PropertyContainer(Models.Certificate protocolObject) : base(BindingState.Bound)
            {
                this.CertificateFormatProperty = this.CreatePropertyAccessor<Common.CertificateFormat?>(
                    nameof(CertificateFormat),
                    BindingAccess.None);
                this.DataProperty = this.CreatePropertyAccessor<string>(
                    nameof(Data),
                    BindingAccess.None);
                this.DeleteCertificateErrorProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.DeleteCertificateError, o => new DeleteCertificateError(o).Freeze()),
                    nameof(DeleteCertificateError),
                    BindingAccess.Read);
                this.PasswordProperty = this.CreatePropertyAccessor<string>(
                    nameof(Password),
                    BindingAccess.None);
                this.PreviousStateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.CertificateState, Common.CertificateState>(protocolObject.PreviousState),
                    nameof(PreviousState),
                    BindingAccess.Read);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.PreviousStateTransitionTime,
                    nameof(PreviousStateTransitionTime),
                    BindingAccess.Read);
                this.PublicDataProperty = this.CreatePropertyAccessor(
                    protocolObject.PublicData,
                    nameof(PublicData),
                    BindingAccess.Read);
                this.StateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.CertificateState, Common.CertificateState>(protocolObject.State),
                    nameof(State),
                    BindingAccess.Read);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.StateTransitionTime,
                    nameof(StateTransitionTime),
                    BindingAccess.Read);
                this.ThumbprintProperty = this.CreatePropertyAccessor(
                    protocolObject.Thumbprint,
                    nameof(Thumbprint),
                    BindingAccess.Read);
                this.ThumbprintAlgorithmProperty = this.CreatePropertyAccessor(
                    protocolObject.ThumbprintAlgorithm,
                    nameof(ThumbprintAlgorithm),
                    BindingAccess.Read);
                this.UrlProperty = this.CreatePropertyAccessor(
                    protocolObject.Url,
                    nameof(Url),
                    BindingAccess.Read);
            }
        }

        private PropertyContainer propertyContainer;

        private readonly BatchClient parentBatchClient;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate"/> class.
        /// </summary>
        /// <param name='parentBatchClient'>The parent <see cref="BatchClient"/> to use.</param>
        /// <param name='baseBehaviors'>The base behaviors to use.</param>
        /// <param name='data'>The base64-encoded raw certificate data (contents of the .pfx or .cer file or data from which the <see cref="Certificate"/> 
        /// was created).</param>
        /// <param name='thumbprint'>The thumbprint of the certificate. This is a sequence of up to 40 hex digits.</param>
        /// <param name='thumbprintAlgorithm'>The algorithm used to derive the thumbprint.</param>
        /// <param name='certificateFormat'>The format of the certificate data.</param>
        /// <param name='password'>The password to access the certificate private key.</param>
        internal Certificate(
            BatchClient parentBatchClient,
            IEnumerable<BatchClientBehavior> baseBehaviors,
            string data,
            string thumbprint,
            string thumbprintAlgorithm,
            Common.CertificateFormat? certificateFormat = default(Common.CertificateFormat?),
            string password = default(string))
        {
            this.propertyContainer = new PropertyContainer();
            this.parentBatchClient = parentBatchClient;
            this.Data = data;
            this.Thumbprint = thumbprint;
            this.ThumbprintAlgorithm = thumbprintAlgorithm;
            this.CertificateFormat = certificateFormat;
            this.Password = password;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
        }

        /// <summary>
        /// Default constructor to support mocking the <see cref="Certificate"/> class.
        /// </summary>
        protected Certificate()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal Certificate(
            BatchClient parentBatchClient,
            Models.Certificate protocolObject,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region IInheritedBehaviors

        /// <summary>
        /// Gets or sets a list of behaviors that modify or customize requests to the Batch service
        /// made via this <see cref="Certificate"/>.
        /// </summary>
        /// <remarks>
        /// <para>These behaviors are inherited by child objects.</para>
        /// <para>Modifications are applied in the order of the collection. The last write wins.</para>
        /// </remarks>
        public IList<BatchClientBehavior> CustomBehaviors { get; set; }

        #endregion IInheritedBehaviors

        #region Certificate

        /// <summary>
        /// Gets the format of the certificate data.
        /// </summary>
        public Common.CertificateFormat? CertificateFormat
        {
            get { return this.propertyContainer.CertificateFormatProperty.Value; }
            private set { this.propertyContainer.CertificateFormatProperty.Value = value; }
        }

        /// <summary>
        /// Gets the base64-encoded raw certificate data (contents of the .pfx or .cer file or data from which the <see cref="Certificate"/> 
        /// was created).
        /// </summary>
        /// <remarks>
        /// <para>This property is set when creating a new <see cref="Certificate"/>. It is not defined for certificates 
        /// retrieved from the Batch service.</para> <para>The maximum size is 10 KB.</para>
        /// </remarks>
        public string Data
        {
            get { return this.propertyContainer.DataProperty.Value; }
            private set { this.propertyContainer.DataProperty.Value = value; }
        }

        /// <summary>
        /// Gets the error that occurred on the last attempt to delete this certificate.
        /// </summary>
        /// <remarks>
        /// This property is null unless the certificate is in the <see cref="Common.CertificateState.DeleteFailed"/> state.
        /// </remarks>
        public DeleteCertificateError DeleteCertificateError
        {
            get { return this.propertyContainer.DeleteCertificateErrorProperty.Value; }
        }

        /// <summary>
        /// Gets the password to access the certificate private key.
        /// </summary>
        /// <remarks>
        /// This property is set when creating a new <see cref="Certificate"/> from .pfx format data (see <see cref="CertificateOperations.CreateCertificateFromPfx(byte[], 
        /// string)"/> and <see cref="CertificateOperations.CreateCertificateFromPfx(string, string)"/>). It is not defined 
        /// for certificates retrieved from the Batch service.
        /// </remarks>
        public string Password
        {
            get { return this.propertyContainer.PasswordProperty.Value; }
            private set { this.propertyContainer.PasswordProperty.Value = value; }
        }

        /// <summary>
        /// Gets the previous state of the certificate.
        /// </summary>
        /// <remarks>
        /// If the certificate is in its initial <see cref="Common.CertificateState.Active"/> state, the PreviousState property 
        /// is not defined.
        /// </remarks>
        public Common.CertificateState? PreviousState
        {
            get { return this.propertyContainer.PreviousStateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the certificate entered its previous state.
        /// </summary>
        /// <remarks>
        /// If the certificate is in its initial <see cref="Common.CertificateState.Active"/> state, the PreviousStateTransitionTime 
        /// property is not defined.
        /// </remarks>
        public DateTime? PreviousStateTransitionTime
        {
            get { return this.propertyContainer.PreviousStateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets the public part of the certificate as a string containing base-64 encoded .cer format data.
        /// </summary>
        public string PublicData
        {
            get { return this.propertyContainer.PublicDataProperty.Value; }
        }

        /// <summary>
        /// Gets the current state of the certificate.
        /// </summary>
        public Common.CertificateState? State
        {
            get { return this.propertyContainer.StateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the certificate entered its current state.
        /// </summary>
        public DateTime? StateTransitionTime
        {
            get { return this.propertyContainer.StateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets the thumbprint of the certificate. This is a sequence of up to 40 hex digits.
        /// </summary>
        public string Thumbprint
        {
            get { return this.propertyContainer.ThumbprintProperty.Value; }
            private set { this.propertyContainer.ThumbprintProperty.Value = value; }
        }

        /// <summary>
        /// Gets the algorithm used to derive the thumbprint.
        /// </summary>
        public string ThumbprintAlgorithm
        {
            get { return this.propertyContainer.ThumbprintAlgorithmProperty.Value; }
            private set { this.propertyContainer.ThumbprintAlgorithmProperty.Value = value; }
        }

        /// <summary>
        /// Gets the URL of the certificate.
        /// </summary>
        public string Url
        {
            get { return this.propertyContainer.UrlProperty.Value; }
        }

        #endregion // Certificate

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.CertificateAddParameter ITransportObjectProvider<Models.CertificateAddParameter>.GetTransportObject()
        {
            Models.CertificateAddParameter result = new Models.CertificateAddParameter()
            {
                CertificateFormat = UtilitiesInternal.MapNullableEnum<Common.CertificateFormat, Models.CertificateFormat>(this.CertificateFormat),
                Data = this.Data,
                Password = this.Password,
                Thumbprint = this.Thumbprint,
                ThumbprintAlgorithm = this.ThumbprintAlgorithm,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}