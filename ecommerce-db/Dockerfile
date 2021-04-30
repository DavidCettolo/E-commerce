FROM mcr.microsoft.com/mssql/server
USER root
RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app
COPY ./ecommerce-db /usr/src/app
RUN chmod +x /usr/src/app/import.sh
USER mssql
CMD /bin/bash ./entrypoint.sh