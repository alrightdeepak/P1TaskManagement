CREATE OR REPLACE PROCEDURE EditTask_SP(
uid INTEGER,
tid INTEGER,
descr VARCHAR(50),
status BOOLEAN
)
LANGUAGE plpgsql
AS
$$
BEGIN
	UPDATE taskitem SET description=newDescription, status=newStatus WHERE taskid=tId and userid=uId;
END
$$