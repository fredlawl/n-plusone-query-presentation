.PHONY: default
default: build;

CONTAINER_NAME := nplusonedb

.PHONY: build run stop profile
build:
	docker build --tag=$(CONTAINER_NAME) .

run: build
	docker run -p 8888:3306 --name $(CONTAINER_NAME) $(CONTAINER_NAME)

stop:
	docker stop $(CONTAINER_NAME)
	docker rm $(CONTAINER_NAME)

profile:
	docker exec nplusonedb tail -f /var/log/mysqld-profile.log
