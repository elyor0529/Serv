# Serv

Вопрос 1 из 2:
Сделать windows service для выполнения задач из базы. - Tasker


В базе должна быть таблица со следующим минимальным набором колонок (можно добавить любые необходимые колонки):

- название задачи

- дата и время раньше которого задача не должна быть выполнена

- параметр - строка


В таблицу попадают задачи для выполнения. Возможны следующие типы задач:

- делает delay 10 сек. после этого создает пустой файл (в любой папке на усмотрение разработчика) с именем указанным в параметре

- отправляет письмо с темой, текстом и адресом отправителя указанными в параметрах.


Настройки smtp сервера и строку подключения к базе данных можно хранить где угодно на усмотрение разработчика.

Для решения задачи обязательно использовать базу данный MS SQL версии не ниже 2012, для работы с базой данных использовать Entity Framework последней версии.


Особенности таскера:

- может быть запущено любое количество сервисов на любом количестве машин (все сервисы подключены к одной и тойже базе данных), при этом должна быть гарантия (код должен быть написан таким образом) что каждая задача (строка в базе данных) должна быть выполненна один раз - не более не менее.

- сделать удобный способ установки и удаления windows service

- сделать режим для отладки таскера, когда он работает не в виде windows service, а в виде обычного консольного приложения

- список выполняемых задач должен быть легко расширяем - написать инструкцию что нужно сделать для добавления еще одного типа задач в список поддерживаемых


Важно!

присылать только исходники, без бинарников, архивы более 1 мегабайта к проверке не допускаются
