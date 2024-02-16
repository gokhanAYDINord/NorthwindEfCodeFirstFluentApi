FROM rabbitmq:3.10-management

# Define environment variables.
ENV RABBITMQ_USER arcuser
ENV RABBITMQ_PASSWORD elma1kalem
ENV RABBITMQ_PID_FILE /var/lib/rabbitmq/mnesia/rabbitmq

ADD init.sh /init.sh
RUN chmod +x /init.sh
EXPOSE 15672

# Define default command
CMD ["/init.sh"]
