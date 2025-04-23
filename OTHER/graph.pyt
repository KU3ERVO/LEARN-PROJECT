import matplotlib.pyplot as plt

# Tasks and their average time spent (in percentage)
tasks = [
    "Market Analysis", 
    "Brainstorming", 
    "GDD Creation", 
    "Production", 
    "Testing", 
    "Launch", 
    "Maintenance", 
    "Postproduction"
]

# Time percentages (estimated averages for game dev projects)
time_spent = [5, 5, 10, 50, 10, 5, 5, 10]

# Create the bar chart
plt.figure(figsize=(10, 6))
plt.barh(tasks, time_spent, color='skyblue')
plt.xlabel('Percentage of Time Spent (%)')
plt.title('Average Time Spent on Tasks in Game Development Projects')
plt.xlim(0, 100)

# Show the graph
plt.show()