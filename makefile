default:
	make start
	make build
	make stop

start:
	docker-compose up -d
	@echo "Server disponivel na porta: http://localhost:8080/"

build:
	docker compose watch
	@echo "Server disponivel na porta: http://localhost:8080/"

stop:
	docker-compose -f compose.yaml stop 
	@echo "Server indisponivel na porta: http://localhost:8080/