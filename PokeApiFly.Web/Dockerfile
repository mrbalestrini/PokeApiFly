FROM nginx:alpine

# Adiciona uma configuração personalizada do Nginx para suportar SPA com vueRouterMode: 'hash'
COPY nginx.conf /etc/nginx/conf.d/default.conf

# Copia os arquivos estaticamente gerados do Quasar
COPY dist/spa/ /usr/share/nginx/html
