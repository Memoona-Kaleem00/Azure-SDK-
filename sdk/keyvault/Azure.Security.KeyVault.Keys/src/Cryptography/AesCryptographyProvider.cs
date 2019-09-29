﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Security.KeyVault.Keys.Cryptography
{
    internal class AesCryptographyProvider : ICryptographyProvider
    {
        private readonly JsonWebKey _jwk;

        internal AesCryptographyProvider(JsonWebKey jwk)
        {
            _jwk = jwk;
        }

        public bool ShouldRemote => _jwk.KeyId != null;

        public bool SupportsOperation(KeyOperation operation)
        {
            if (_jwk != null)
            {
                if (operation == KeyOperation.Encrypt || operation == KeyOperation.Decrypt || operation == KeyOperation.WrapKey || operation == KeyOperation.UnwrapKey)
                {
                    return _jwk.SupportsOperation(operation);
                }
            }

            return false;
        }

        public DecryptResult Decrypt(EncryptionAlgorithm algorithm, byte[] ciphertext, byte[] iv, byte[] authenticationData, byte[] authenticationTag, CancellationToken cancellationToken)
        {
            // TODO: Log if not supported locally.
            return null;
        }

        public Task<DecryptResult> DecryptAsync(EncryptionAlgorithm algorithm, byte[] ciphertext, byte[] iv, byte[] authenticationData, byte[] authenticationTag, CancellationToken cancellationToken)
        {
            DecryptResult result = Decrypt(algorithm, ciphertext, iv, authenticationData, authenticationTag, cancellationToken);
            return Task.FromResult(result);
        }

        public EncryptResult Encrypt(EncryptionAlgorithm algorithm, byte[] plaintext, byte[] iv, byte[] authenticationData, CancellationToken cancellationToken)
        {
            // TODO: Log if not supported locally.
            return null;
        }

        public Task<EncryptResult> EncryptAsync(EncryptionAlgorithm algorithm, byte[] plaintext, byte[] iv, byte[] authenticationData, CancellationToken cancellationToken)
        {
            EncryptResult result = Encrypt(algorithm, plaintext, iv, authenticationData, cancellationToken);
            return Task.FromResult(result);
        }

        public UnwrapResult UnwrapKey(KeyWrapAlgorithm algorithm, byte[] encryptedKey, CancellationToken cancellationToken)
        {
            Argument.AssertNotNull(encryptedKey, nameof(encryptedKey));

            int algorithmKeySize = algorithm.GetKeySize();
            if (algorithmKeySize == 0)
            {
                // TODO: Log that we don't support the algorithm locally.
                return null;
            }

            int keySize = GetKeySize();
            if (keySize != algorithmKeySize)
            {
                throw new ArgumentException($"Key wrap algorithm {algorithm} key size {algorithmKeySize} does not match underlying key size {keySize}");
            }

            using Aes aes = _jwk.ToAes();
            using ICryptoTransform decryptor = aes.CreateDecryptor();

            byte[] key = decryptor.TransformFinalBlock(encryptedKey, 0, encryptedKey.Length);
            return new UnwrapResult
            {
                Algorithm = algorithm,
                Key = key,
                KeyId = _jwk.KeyId,
            };
        }

        public Task<UnwrapResult> UnwrapKeyAsync(KeyWrapAlgorithm algorithm, byte[] encryptedKey, CancellationToken cancellationToken)
        {
            UnwrapResult result = UnwrapKey(algorithm, encryptedKey, cancellationToken);
            return Task.FromResult(result);
        }

        public WrapResult WrapKey(KeyWrapAlgorithm algorithm, byte[] key, CancellationToken cancellationToken)
        {
            Argument.AssertNotNull(key, nameof(key));

            int algorithmKeySize = algorithm.GetKeySize();
            if (algorithmKeySize == 0)
            {
                // TODO: Log that we don't support the algorithm locally.
                return null;
            }

            int keySize = GetKeySize();
            if (keySize != algorithmKeySize)
            {
                throw new ArgumentException($"Key wrap algorithm {algorithm} key size {algorithmKeySize} does not match underlying key size {keySize}");
            }

            using Aes aes = _jwk.ToAes();
            using ICryptoTransform encryptor = aes.CreateEncryptor();

            byte[] encryptedKey = encryptor.TransformFinalBlock(key, 0, key.Length);
            return new WrapResult
            {
                Algorithm = algorithm,
                EncryptedKey = encryptedKey,
                KeyId = _jwk.KeyId,
            };
        }

        public Task<WrapResult> WrapKeyAsync(KeyWrapAlgorithm algorithm, byte[] key, CancellationToken cancellationToken)
        {
            WrapResult result = WrapKey(algorithm, key, cancellationToken);
            return Task.FromResult(result);
        }

        private int GetKeySize()
        {
            if (_jwk.K != null)
            {
                return _jwk.K.Length << 3;
            }

            return 0;
        }

        #region Unsupported operations
        SignResult ICryptographyProvider.Sign(SignatureAlgorithm algorithm, byte[] digest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<SignResult> ICryptographyProvider.SignAsync(SignatureAlgorithm algorithm, byte[] digest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        VerifyResult ICryptographyProvider.Verify(SignatureAlgorithm algorithm, byte[] digest, byte[] signature, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<VerifyResult> ICryptographyProvider.VerifyAsync(SignatureAlgorithm algorithm, byte[] digest, byte[] signature, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
