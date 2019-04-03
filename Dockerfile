FROM mysql/mysql-server:5.7

ENV MYSQL_ROOT_HOST=%
ENV MYSQL_ROOT_PASSWORD=nplusone
ENV MYSQL_DATABASE=nplusone

ADD ./my.cnf /etc/my.cnf
ADD ./dump.sql /docker-entrypoint-initdb.d/dump.sql

RUN touch /var/log/mysqld-profile.log
RUN chown mysql:mysql /var/log/mysqld-profile.log
