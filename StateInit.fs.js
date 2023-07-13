
export function init() {
    return 0;
}

export function update(msg, count) {
    if (msg.tag === 1) {
        return (count - 1) | 0;
    }
    else {
        return (count + 1) | 0;
    }
}

