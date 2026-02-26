CREATE OR REPLACE FUNCTION showTasks_func(
p_userid integer
)
RETURNS TABLE(
taskid INTEGER,
description VARCHAR(50),
status BOOLEAN
)
LANGUAGE plpgsql
AS
$$
BEGIN
	RETURN QUERY
	SELECT t.taskid,t.description,t.status FROM taskitem t WHERE userid=p_userid ORDER BY t.taskid ASC;
END
$$