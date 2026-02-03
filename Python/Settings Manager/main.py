test_settings = {"dark mode": "on"}

def add_setting (settings, new):
    name = new[0].lower()
    value = new[1].lower()
    
    if name in settings.keys():
        return f"Setting '{name}' already exists! Cannot add a new setting with this name."
    else:
        settings[name] = value
        return f"Setting '{name}' added with value '{value}' successfully!"

def update_setting(settings, new):
    name = new[0].lower()
    value = new[1].lower()

    if name in settings.keys():
        settings[name] = value
        return f"Setting '{name}' updated to '{value}' successfully!"
    else:
        return f"Setting '{name}' does not exist! Cannot update a non-existing setting."

def delete_setting(settings, n):
    name = n.lower()

    if name in settings.keys():
        del settings[name]
        return f"Setting '{name}' deleted successfully!"
    else:
        return "Setting not found!"

def view_settings(settings):

    if len(settings.items()) == 0:
        return "No settings available."

    ret = "Current User Settings:\n"
    for key, value in settings.items():
        ret += key[0].upper() + key[1:] + ": " + value + "\n"
    return ret

test_settings['notifications'] = 'enabled'

print(view_settings(test_settings))