function addTask(section) {
    const taskColumn = document.querySelector(`.${section}`);
    const newTask = document.createElement('div');
    newTask.className = 'task';
    newTask.textContent = `New Task ${Math.floor(Math.random() * 100) + 1}`;
    taskColumn.insertBefore(newTask, taskColumn.querySelector('.add-task-btn'));
}
function addTask(section) {
    const taskColumn = document.querySelector(`.${section}`);
    const newTask = document.createElement('div');
    newTask.className = 'task';
    newTask.textContent = `New Task ${Math.floor(Math.random() * 100) + 1}`;
    taskColumn.insertBefore(newTask, taskColumn.querySelector('.add-task-btn'));
}
