 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44386/',
  redirectUri: baseUrl,
  clientId: 'BookStoreApp_App',
  responseType: 'code',
  scope: 'offline_access BookStoreApp',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookStoreApp',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44386',
      rootNamespace: 'Acme.BookStoreApp',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
