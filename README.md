https://roadmap.sh/projects/task-tracker

Requirements
The application should run from the command line, accept user actions and inputs as arguments, and store the tasks in a JSON file. The user should be able to:

[] Add, Update, and Delete tasks
[] Mark a task as in progress or done
[] List all tasks
[] List all tasks that are done
[] List all tasks that are not done
[] List all tasks that are in progress

Examples

task-cli add "Buy groceries" // add "string_arg"
# Output: Task added successfully (ID: 1)

# Updating and deleting tasks
task-cli update 1 "Buy groceries and cook dinner" // update "num_arg" "string_arg"
task-cli delete 1 // delete "num_arg"

# Marking a task as in progress or done
task-cli mark-in-progress 1
task-cli mark-done 1

# Listing all tasks
task-cli list

# Listing tasks by status
task-cli list done
task-cli list todo
task-cli list in-progress