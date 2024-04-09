using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Netcore.ActivoFijo.Business
{
    public class AccessToken
    {
        public static string GenerateAccessToken(Persona person)
        {
            List<Claim> listClaims = new List<Claim>()
            {
                new Claim(Netcore.ActivoFijo.Enum.EnumClaims.Rut.ToString(), person.Run)
            };

            SymmetricSecurityKey key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(Netcore.Abstraction.StaticParams.StaticParams.Secret));

            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            EncryptingCredentials encryptingCredentials = new EncryptingCredentials(key, JwtConstants.DirectKeyUseAlg, SecurityAlgorithms.Aes256CbcHmacSha512);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityTokenHandler().CreateJwtSecurityToken(
                issuer: "netcore",
                audience: "netcore",
                subject: new ClaimsIdentity(listClaims),
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(24),
                issuedAt: DateTime.Now,
                signingCredentials: creds,
                encryptingCredentials: encryptingCredentials,
                claimCollection: listClaims.ToDictionary(k => k.Type, v => (object)v.Value)
                );

            string encryptedJWT = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return encryptedJWT;
        }

        public static string GenerateAccessTokenEnterpriseConnection(Persona person, string connectionString, Guid enterpriseId)
        {
            List<Claim> listClaims = new List<Claim>();

            Claim userClaim = new Claim(Netcore.ActivoFijo.Enum.EnumClaims.Rut.ToString(), person.Run);
            Claim connectionStringClaim = new Claim(Netcore.ActivoFijo.Enum.EnumClaims.ConnectionString.ToString(), connectionString);
            Claim enterpriseClaim = new Claim(Netcore.ActivoFijo.Enum.EnumClaims.EnterpriseId.ToString(), enterpriseId.ToString());

            listClaims.Add(userClaim);
            listClaims.Add(connectionStringClaim);
            listClaims.Add(enterpriseClaim);

            SymmetricSecurityKey key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(Netcore.Abstraction.StaticParams.StaticParams.Secret));

            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            EncryptingCredentials encryptingCredentials = new EncryptingCredentials(key, JwtConstants.DirectKeyUseAlg, SecurityAlgorithms.Aes256CbcHmacSha512);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityTokenHandler().CreateJwtSecurityToken(
                issuer: "netcore",
                audience: "netcore",
                subject: new ClaimsIdentity(listClaims),
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(24),
                issuedAt: DateTime.Now,
                signingCredentials: creds,
                encryptingCredentials: encryptingCredentials,
                claimCollection: listClaims.ToDictionary(k => k.Type, v => (object)v.Value)
                );

            string encryptedJWT = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return encryptedJWT;
        }

        public static bool ValidateToken(string token, string secretKey)
        {
            try
            {
                JwtSecurityTokenHandler jwt = new JwtSecurityTokenHandler();

                TokenValidationParameters tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                    TokenDecryptionKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                    ClockSkew = TimeSpan.Zero
                };

                SecurityToken validatedToken;
                ClaimsPrincipal principal = (ClaimsPrincipal)jwt.ValidateToken(token, tokenValidationParameters, out validatedToken);

                JwtSecurityToken? tokenS = jwt.ReadToken(token) as JwtSecurityToken;

                string? isValidClaim = principal.Claims.FirstOrDefault().Value;

                if (validatedToken.ValidFrom <= DateTime.UtcNow && validatedToken.ValidTo >= DateTime.UtcNow)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}